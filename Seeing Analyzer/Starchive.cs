using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;


namespace Seeing_Analyzer
{
    /*Starchive Class
     * 
     * This class encapsulates methods for storing and retrieving photometry data
     * on individual stars
     *
     */

    class Starchive
    {
        string starchiveFolder = "Starchive";
        string starchiveFile = "Starchive.xml";
        string starchivePath = "";

        public class PhotoData
        {
            public string StarName { get; set; }
            public DateTime StarDate { get; set; }
            public string StarFilter { get; set; }
            public double StarInstMag { get; set; }
            public double StarMagDelta { get; set; }

            public PhotoData(string nameS, DateTime dateS, string filterS, double instMagS, double magDeltaS)
            {
                StarName = nameS;
                StarDate = dateS;
                StarFilter = filterS;
                StarInstMag = instMagS;
                StarMagDelta  = magDeltaS;
            }
        }

        //Instantiation
        public Starchive()
        {
            //Check for starchive folder and file.  Create if doesn't exist
            starchiveFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + starchiveFolder;

            if (!Directory.Exists(starchiveFolder))
            {
                Directory.CreateDirectory(starchiveFolder);
            }

            if (File.Exists(starchiveFolder + "\\" + starchiveFile)) starchivePath = starchiveFolder + "\\" + starchiveFile;
            else starchivePath = null;
        }

        /// <summary>
        /// Saves a magnitude for a star on a get date
        /// </summary>
        /// <param name="starName"></param>
        /// <param name="starMag"></param>
        /// <param name="sampleDate"></param>
        public void SetPhotometry(string starName, DateTime sampleDate, string starFilter, double starMag, double magScale)
        {
            //Create an XElement with the data
            XElement newStarXdata = new XElement("StarData",
                                new XElement("StarName", starName),
                                new XElement("StarDate", sampleDate.ToString()),
                                new XElement("StarFilter", starFilter.ToString()),
                                new XElement("StarInstMag", starMag.ToString()),
                                new XElement("StarMagDelta", magScale.ToString()));

            if (starchivePath == null)
            {
                starchivePath = starchiveFolder + "\\" + starchiveFile;
                XElement newPhotometry = new XElement("PhotometrySamples");
                newPhotometry.Add(newStarXdata);
                newPhotometry.Save(starchivePath);
            }
            else
            {
                //ignore duplications
                bool duplicateFlag = false;
                XElement archivedStarX = XElement.Load(starchivePath);
                IEnumerable<XElement> starXlist = archivedStarX.Elements("StarData");
                foreach (XElement star in starXlist)
                {
                    if ((star.Element("StarName").Value == starName) &&
                         (star.Element("StarDate").Value == sampleDate.ToString()) &&
                         (star.Element("StarFilter").Value == starFilter.ToString()) &&
                         (star.Element("StarInstMag").Value == starMag.ToString()))
                    {
                        duplicateFlag = true;
                        break;
                    }
                }
                if (!duplicateFlag)
                {
                    archivedStarX.Add(newStarXdata);
                    archivedStarX.Save(starchivePath);
                }
            }
            return;
        }


        public List<PhotoData> GetPhotometry(string starName, string starFilter)
        {
            //Open file, convert xml entries to list, if any
            List<PhotoData> starList = new List<PhotoData>();

            //Check for file, if doesnt exist, then return
            if (!File.Exists(starchivePath)) return starList;

            XElement starAllXdata = XElement.Load(starchivePath);
            IEnumerable<XElement> starXlist = starAllXdata.Elements("StarData");
            foreach (XElement star in starXlist)
            {
                string tn = star.Element("StarName").Value;
                DateTime td = Convert.ToDateTime(star.Element("StarDate").Value);
                double tMagInst = Convert.ToDouble(star.Element("StarInstMag").Value);
                string tf = star.Element("StarFilter").Value;
                double tMagDelta = Convert.ToDouble(star.Element("StarMagDelta").Value);
                if ((tn == starName) && (tf == starFilter))
                {
                    PhotoData pd = new PhotoData(tn, td, tf, tMagInst, tMagDelta);
                    starList.Add(pd);
                }
            }
            return starList;
        }


    }
}

