// --------------------------------------------------------------------------------
// TSX Helper Applet for analyzing seeing conditions from an image using ImageLink
////
// Description:	This Windows Form applet uses the TSX Image Link functions to analyze star 
//               astrometry { to calculate the seeing conditions at the time the
//               image was taken -- normally a current image.
//               The image of each individual star that is detected is also displayed
//               in a 3D graphical image for visual consideration of diffusion and focus
//               artifacts.
//
// Environment:  Windows 7,8,10 executable, 32 and 64 bit
//
// Usage:        See the "Explanation" Region below
//
// Author:		(REM) Rick McAlister, rrskybox@yahoo.com
//
// Edit Log:     Rev 1.0 Initial Version
//               Rev 1.1
//               Rev 1.2 Updated XYToRADec method
//                       Fixed a bug where I left in a stub for a DSS issue
//                       Changed Inst Mag to Mag Zero Pt Offset which is how far off
//                           the TSX Magnitude Zero Point setting is from where it should be.
//
// Date			Who	Vers	Description
// -----------	---	-----	-------------------------------------------------------
// 02-18-2015	REM	1.0.0	Initial version
// 08-12-2017    REM 1.2.1   Fixes above
// 06-01-2020   REM 2.0.0   Port to C#, added stellar population analysis
// ---------------------------------------------------------------------------------
//

using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TheSky64Lib;

namespace Seeing_Analyzer
{
    public partial class FormSeeingAnalyzer : Form
    {
        public const double NyquistMinimumSamples = 2;
        private bool initFlag = true;

        public FormSeeingAnalyzer()
        {
            initFlag = true;
            InitializeComponent();
            ReadMeButton.BackColor = Color.LightSeaGreen;
            groupBox1.ForeColor = Color.White;
            PhotometryGroupBox.ForeColor = Color.White;
            groupBox3.ForeColor = Color.White;
            InstrumentationGroupBox.ForeColor = Color.White;
            SubframeGroupBox.ForeColor = Color.White;
            // Acquire the version information and put it in the form header
            try { this.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(); }
            catch { this.Text = " in Debug"; } //probably in debug, no version info available
            this.Text = "Seeing Analyzer V" + this.Text;
            tsximg = new ccdsoftImage();
            initFlag = false;
            SessionHoursBox.Value = (decimal)Properties.Settings.Default.SessionHours;
            GainBox.Value = (decimal)Properties.Settings.Default.Egain;
            ReadNoiseBox.Value = (decimal)Properties.Settings.Default.ReadNoise;
            MaxReadNoiseBox.Value = (decimal)Properties.Settings.Default.MaxReadNoise;
            MinFaintADU.Value = (decimal)Properties.Settings.Default.MinFaintADU;
            SNRPercentBox.Value = (decimal)Properties.Settings.Default.SNR_Percent;
        }

        #region Explanation

        public const string seeinginst = "Seeing Profiler Instructions: " + "\r\n" + "\r\n" +
            "This applet extracts atmospheric seeing qualities from a TSX image-linked picture," + "\r\n" +
            "  and produces a graphical plot of the intensity for each star recognized" + "\r\n" +
            "  in that image. This applet is based largly on the work of Bruce MacEvoy," + "\r\n" +
            " Bruce MacEvoy: www.handprint.com/ASTRO/seeing1.html and www.handprint.com/ASTRO/seeing2.html." + "\r\n" +
            "\r\n" +
            "The Seeing qualities computed from the FITS information and image-linking are: " + "\r\n" +
            "  1. Resolution of camera in arcsecs (based on telescope and camera parameters) " + "\r\n" +
            "  2. Airy disk in arcsec (based on telescope and camera parameters) " + "\r\n" +
            "  3. Seeing in arcsec (based on resolution and average FWHM of image stars) " + "\r\n" +
            "  4. Seeing Class based on Seeing and Aperture" + "\r\n" +
            "     (Environment Canada Seeing Forecast scale: http://weather.gc.ca/astro/seeing_e.html)" + "\r\n" +
            "\r\n" +
            "For each star in the recognized set (ordered by decreasing magnitude), a 3D graph" + "\r\n" +
            "  of twice the FWHM area of the star, based on pixel intensity and displayed with" + "\r\n" +
            "  the following parameters: " + "\r\n" +
            "  1. Relative instrument magnitude " + "\r\n" +
            "  2. FWHM (as computed by in pixels) " + "\r\n" +
            "  3. Ellipsity (as computed by TSX) " + "\r\n" +
            "  4. X,Y position (in pixels) " + "\r\n" +
            "\r\n" +
            "And, the routine uses the Star Chart to identify the star at the source//s" + "\r\n" +
            "  location as determined by the image linking.  The Star Chart is centered" + "\r\n" +
            "  on the image with that specific star identified. " + "\r\n" +
            "\r\n" +
            "Prerequisites:  For the applet to work correctly, the following is required: " + "\r\n" +
            "  1. TSX Telescope properties (aperture, etc) must be entered correctly. " + "\r\n" +
            "  2. TSX Camera properties (scale, etc) must be entered correctly. " + "\r\n" +
            "  3. TSX must be running with an active image.  The image must be" + "\r\n" +
            "     able to be successfully image-linked without using All-Sky. " + "\r\n" +
            "  4. TSX ImageLink All-Sky tab must have //Use All Sky ImageLink for scripted ImageLink// unchecked." + "\r\n" +
            "\r\n" +
            "Note:  Seeing results are most accurate if no image star is saturated or of magnitude brighter than 1." + "\r\n";

        public const string Overview = "" +
            "Simple sub-exposure strategies concentrate exclusively on optimization against random internal noise sources.  Such " +
            "calculations utilize fixed parameters from one's CCD specification like read noise, dark current, etc.  However, they " +
            "fail to compensate for the envioronmental non-random sources of noise such as light pollution, sky glow, turbulence which " +
            "vary from night to night and location to location.  These critical factors can only be accurately derived from an " +
            "appropriate reference image.  Three authors have developed optimal sub-frame exposure algorithms that account for noise " +
            "contribution from both internal (equipment) sources and external (atmospheric) sources. " +
            "\r\n" + "\r\n" +
            "Smith's analysis and algorithm considers both of the two sources of noise in images – random noise and non-random noise. " +
            "His method produces a longer total exposure times but assumes a little more image processing complexity on the back end, " +
            "e.g. dithered image acquisition and outlier-rejection combining algorithms.  The key operative variable for Smith the is " +
            "the maximum Read Noise percentage contribution to the acquired image. " +
            "\r\n" + "\r\n" +
            "Cannestra's algorithm is a variation on Smith's.  Whereas Smith's approach is to optimize the length of each sub-frame " +
            "Cannestra 's algorithm looks to optimize the signal to noise ratio of the final, stacked image.  The operative parameter " +
            "here is that target SNR for the collection.  The calculated sub-frame exposure, however, remains in the ballpark with Smith. " +
            "\r\n" + "\r\n" +
            "Anstey mostly rejects the SNR-only approach based on his experience with much longer sub-frame exposures than " +
            "Smith's algorithm would recommend.  He asserts that a sub-frame exposure must account first for acquisition of the faintest " +
            "target desired, then on SNR considerations.  Thus his operative variable is a value for the faintest target acquisition in " +
            "the accumulated image.  Accordingly, his sub-frame exposure produces a value significantly longer than Smith and Cannestra " +
            "for the same reference image and criteria. " +
            "\r\n" + "\r\n" +
            "This miniapp gives the user an opportunity to compare the results of all three as derived from a 'real-time' reference image. " +
            "Then, based on which analysis seems most reasonable and appropriate, make a choice for that night's imaging. " +
            "\r\n" + "\r\n" +
            "See:" + "\r\n" + "\r\n" +
            "   '   John Smith: http://www.hiddenloft.com/notes/SubExposures.pdf" + "\r\n" +
            "   '   Charles Anstey: http://www.cloudynights.com/item.php?item_id=1622" + "\r\n" +
            "   '   Steve Cannistra: http://www.starrywonders.com/snr.html"
    ;

        #endregion

        public const double maxMagVal = 21;
        public const double minMagVal = 4;
        public const double greenwavelength = 560E-9;

        public int[] StarSort;
        public int CurrentStarIndex;

        public object[] WCSActiveArr;  //WCS star inventory data -- Star used or not
        public object[] WCSRAArr;  //WCS star inventory data -- RA
        public object[] WCSDecArr;  //WCS star inventory data-- Dec
        public object[] WCSXPosArr;  //WCS star inventory data -- X
        public object[] WCSYPosArr;  //WCS star inventory data -- Y

        public object[] MagArr;
        public object[] FWHMArr;
        public object[] EllipticityArr;
        public object[] XPosArr;
        public object[] YPosArr;

        public double Xcen;
        public double Ycen;

        public List<int> magArrPlotIndex;

        public ccdsoftImage tsximg { get; set; }
        public Fits fit { get; set; }
        public Star photoStar { get; set; }
        public ImageLink tsxilk { get; set; }
        public double SaturationADU { get; set; }
        public double MeanMagRatio { get; set; }
        public double FocalRatio { get; set; }
        public double PixelScale_arcsec { get; set; }
        public bool FitsIsOpen { get; set; }

        private void Analyze()
        {

            //This is the primary routine.  The current image in TSX is activated and FITS information acquired.
            //  The image is { sent through image link to compute WCS information for each star.
            //  The results are sorted by magnitude, averaged, seeing estimated and results displayed.
            //

            //tsximg = new ccdsoftImage();
            tsxilk = new ImageLink();
            //Minimize TSX to improve performance
            ManageTSX.MinimizeTSX();

            //Using FITS file information...
            fit = new Fits(tsximg);

            //Compute pixel scale = 206.256 * pixel size (in microns) / focal length
            //Set initial values in case the FITS words aren't there
            fit.PixSize = fit.PixSize ?? 10;
            fit.Gain = fit.Gain ?? Properties.Settings.Default.Egain;
            if (fit.FocalLength == null) MessageBox.Show("Focal Length was not set for this FITS image: defaulting to 2000 mm");
            fit.FocalLength = fit.FocalLength ?? 2000; //mm
            if (fit.Aperture == null) MessageBox.Show("Aperture was not set for this FITS image: defaulting to 254 mm");
            fit.Aperture = fit.Aperture ?? 254.0; //mm
            FocalRatio = (double)fit.FocalLength / (double)fit.Aperture;

            fit.Exposure = fit.Exposure ?? 0;
            //  focal length must be set to correct value in FITS header -- comes from camera set up in TSX
            PixelScale_arcsec = ConvertToArcSec((double)fit.PixSize, (double)fit.FocalLength);

            //Set the pixel scale for an InsertWCS image linking
            tsximg.ScaleInArcsecondsPerPixel = PixelScale_arcsec;

            //Instrument calculations for perfect seeing conditions
            //Calculate the theoretical star Airy Disk size (in arc sec) for this focal length under perfect seeing conditions
            //  ad = arcSin(1.22*wavelength/aperture)
            double airyDisk_arcsec = 2 * Math.Asin(1.22 * (greenwavelength / (((double)fit.Aperture) * 1E-3))) * (180.0 / Math.PI) * 60.0 * 60.0;
            double airyDisk_micron = ConvertToMicrons(airyDisk_arcsec, (double)fit.FocalLength);
            //Calculate the size (in microns) of a pixel that is able to meet Nyquist criteria for detecting a star image of this size.
            //    airy disk diameter * 6 -- in arcsec and microns
            double airyNyquist_micron = airyDisk_micron / 6;
            double airyNyquist_arcsec = ConvertToArcSec(airyDisk_micron / 6, ((double)fit.FocalLength));
            //Star measurements are of the FWHM of the detected 2D signal, so all calculations must be in terms of FWHM
            //Calculate FWHM of Airy Disk in arcsec and microns
            double airyDiskFWHM_micron = 1.02 * greenwavelength * ((double)fit.FocalLength / (double)fit.Aperture) * 1e6;
            double airyDiskFWHM_arcsec = ConvertToArcSec(airyDiskFWHM_micron, (double)fit.FocalLength);
            //Calcualte the maximum focal length for detection under perfect conditions
            //
            //Calculate the minimum aperture for detection under perfect condtions
            //
            //Calculate the theoretical minimum detectable star size at perfect seeing conditions with this pixel size and focal length in arcsec
            double minimumDetectableSeeingFWHM = ConvertToArcSec((double)fit.PixSize * NyquistMinimumSamples, (double)fit.FocalLength);
            //Calculate the minimum measureable seeing condition for this pixel size and focal length
            //


            //set saturation threshold
            SaturationADU = Math.Pow(2, (double)fit.PixBits) * 0.95;

            //ImageLink for light sources (Insert WCS)
            try { int ferr = tsximg.InsertWCS(true); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            //Collect astrometric light source data from the image linking into single index arrays: 
            //  magnitude, fmhm, ellipsicity, x and y position
            // double[] resultArray = Array.ConvertAll<object, double>
            //              (inputArray, x => (double)x);
            try { MagArr = (tsximg.InventoryArray((int)TSXEnums.ccdsoftInventoryIndex.cdInventoryMagnitude)); }
            catch { return; }
            FWHMArr = tsximg.InventoryArray((int)TSXEnums.ccdsoftInventoryIndex.cdInventoryFWHM); //FMHW, we think
            EllipticityArr = tsximg.InventoryArray((int)TSXEnums.ccdsoftInventoryIndex.cdInventoryEllipticity);//Ellipsity, we think
            XPosArr = tsximg.InventoryArray((int)TSXEnums.ccdsoftInventoryIndex.cdInventoryX);//X position, we think
            YPosArr = tsximg.InventoryArray((int)TSXEnums.ccdsoftInventoryIndex.cdInventoryY); //Y position, we think

            try { WCSActiveArr = (tsximg.WCSArray((int)TSXEnums.ccdsoftWCSIndex.cdActive)); }
            catch { return; }
            WCSRAArr = tsximg.WCSArray((int)TSXEnums.ccdsoftWCSIndex.cdWCSRA);
            WCSDecArr = tsximg.WCSArray((int)TSXEnums.ccdsoftWCSIndex.cdWCSDec);
            WCSXPosArr = tsximg.WCSArray((int)TSXEnums.ccdsoftWCSIndex.cdWCSX);
            WCSYPosArr = tsximg.WCSArray((int)TSXEnums.ccdsoftWCSIndex.cdWCSY);

            //Fill in Seeing Analysis information in the windows form: 
            //Instrument info
            FocalLengthBox.Text = ((double)fit.FocalLength).ToString("0");
            ApertureBox.Text = ((double)fit.Aperture).ToString("0");
            FocalRatioBox.Text = FocalRatio.ToString("0.0");
            PixSizeMicronBox.Text = ((double)fit.PixSize).ToString("0.0");
            PixSizeArcSecBox.Text = (ConvertToArcSec((double)fit.PixSize, (double)fit.FocalLength)).ToString("0.00");
            MaxResolutionArcSecBox.Text = ((ConvertToArcSec((double)fit.PixSize, (double)fit.FocalLength)) * 3.3).ToString("0.00");
            PerfectPixelMicronBox.Text = (airyNyquist_micron).ToString("0.0");
            PerfectPixelArcSecBox.Text = (airyNyquist_arcsec).ToString("0.0");
            GainBox.Value = (decimal)fit.Gain;

            //   Resolution, Airy Disk size, Seeing as FWHM average measurement, Seeing as set on the Canadian scale
            AiryDiskarcsecBox.Text = airyDisk_arcsec.ToString("0.00");
            AiryDiskmicronBox.Text = airyDisk_micron.ToString("0.0");

            //double FWHMAvg = 0;
            //for (int i = 0; i < FWHMArr.Length; i++) FWHMAvg = FWHMAvg + (double)FWHMArr[i];
            //FWHMAvg = FWHMAvg / FWHMArr.Length;
            double FWHMAvg_pixels = MathNet.Numerics.Statistics.ArrayStatistics.Mean(Array.ConvertAll<object, double>(FWHMArr, x => (double)x));
            double EllipticityAvg = MathNet.Numerics.Statistics.ArrayStatistics.Mean(Array.ConvertAll<object, double>(EllipticityArr, x => (double)x));
            //Star Size = (Seeing * Focal Length)/206.3 => Seeing = Star Size *206.3/focal length or Seeing = FWHM * focal length/ 206.3* microns;
            double FWHMAvg_arcsec = FWHMAvg_pixels * tsximg.ScaleInArcsecondsPerPixel;
            double FWHMAvg_micron = FWHMAvg_pixels * (double)fit.PixSize;
            MeanFWHMBox.Text = FWHMAvg_arcsec.ToString("0.00");
            double fwhmSeeing_arcsec = FWHMAvg_micron * 206.3 / ((double)fit.FocalLength);

            SeeingClassBox.Text = GetSeeingClass(FWHMAvg_arcsec, (double)fit.Aperture);
            MeanEllipticityBox.Text = EllipticityAvg.ToString("0.00");
            //Create sorted index of stars, based on magnitude, high to low
            //Generate initial ordered array
            StarSort = new int[MagArr.Length];
            for (int fi = 0; fi < StarSort.Length; fi++) StarSort[fi] = fi;

            //Create an index table (StarSort) through which index pointers to the light source data arrays can be arranged
            //  Sort the index pointers in StarSort in the order of decreasing magnitude of the light source data
            //  using a simple bubble sort algorithm: exchange the place of each successive pair of index pointers until
            //  the magnitudes that they point to go from larger to smaller, in order.

            //Loop: until the flag remains false for an entire progression through the sort array, that is:
            // Start loop
            //  Set sort flag to false (to indicate no exchange has occurred)
            //  For each sucessive pair of magnitudes, swap their position index pointers if the first is less than the second, and set flag true
            //  Continue through the index pointer list.
            //  Do it again until no swaps occur (flag is false)

            bool bubbleflag;
            int temp;
            do
            {
                bubbleflag = true;
                for (int fi = 1; fi < StarSort.Length; fi++)
                {
                    if ((double)MagArr[StarSort[fi - 1]] > (double)MagArr[StarSort[fi]])
                    {
                        temp = StarSort[fi - 1];
                        StarSort[fi - 1] = StarSort[fi];
                        StarSort[fi] = temp;
                        bubbleflag = false;
                    }
                }
            } while (!bubbleflag);
            //check the sorting
            for (int fi = 1; fi < StarSort.Length; fi++)
            {
                if ((double)MagArr[StarSort[fi - 1]] > (double)MagArr[StarSort[fi]]) MessageBox.Show("bad order at " + (fi).ToString());
            }
            //Set the global sort array index to the first (greatest magnitude) entry {.
            CurrentStarIndex = 0;
            //Graph 10x10 pixel area of star
            if (FitsIsOpen)
            {
                //Done
                //Display target, date and time for fits file
                TargetBox.Text = fit.FitsTarget;
                FileDateBox.Text = fit.FitsDate;
                FileTimeBox.Text = fit.FitsTime;
                //MeanLumBox.Text =  MeanAduToMag(24000).ToString("0.0");
                double backgroundADU = tsximg.Background;
                BackgroundADUBox.Text = backgroundADU.ToString("0");
                ExposureBox.Text = ((double)fit.Exposure).ToString("0.0");
                //Set the global value for the maximum pixel (used for determine staturation) at 95% of maximum ADU
                GraphMagnitudes();
                AnalyzeSubframe();
                GraphStar();
                ArchiveStar();
            }
        }

        private void NextStar()
        {
            //Test for active image
            int serr;
            try { serr = StarSort.Length; }
            catch
            {
                MessageBox.Show("No active image.");
                return;
            }

            CurrentStarIndex += 1;
            if (CurrentStarIndex < StarSort.Length) GraphStar(); //Graph pixel area of star
            else CurrentStarIndex = StarSort.Length - 1;
        }

        private void PriorStar()
        {
            //Test for active image
            int serr;
            try { serr = StarSort.Length; }
            catch
            {
                MessageBox.Show("No active image.");
                return;
            }
            CurrentStarIndex -= 1;
            if (CurrentStarIndex >= 0) GraphStar();  //Graph pixel area of star
            else CurrentStarIndex = 0;
            return;
        }

        private void GraphStar()
        {
            //This routine produces a 3D graph of a star//s astrometric information, from the center out to twice the FWHM radius.

            //Get the star center (x,y) and 2xFWHM (in pixels), as well as the maximum X and Y values

            double RAstar;
            double Decstar;

            double XMax = tsximg.WidthInPixels - 1;
            double YMax = tsximg.HeightInPixels - 1;
            double XCen = (double)XPosArr[StarSort[CurrentStarIndex]];
            //double YCen = YMax - YPosArr[StarSort[CurrentStarIndex]]  //Stub for simulator
            double YCen = (double)YPosArr[StarSort[CurrentStarIndex]];
            int fwhmSpan = (int)((double)FWHMArr[StarSort[CurrentStarIndex]] * 2);
            if (fwhmSpan < 0)
                fwhmSpan = 0;
            //Calculate the lowest and highest X positions for twice the FWHM
            int Pix0 = (int)(XCen - (fwhmSpan / 2));
            if (Pix0 < 0) Pix0 = 0;
            double PixN = XCen + (fwhmSpan / 2);
            if (PixN > XMax) PixN = XMax;

            Series[] Ypix = new Series[fwhmSpan];
            object[] Yline;

            StarADUChart.Series.Clear();
            StarFWHMBox.Text = ((double)FWHMArr[StarSort[CurrentStarIndex]]).ToString("0.00");
            StarEllipticityBox.Text = ((double)EllipticityArr[StarSort[CurrentStarIndex]]).ToString("0.00");

            //Display X and Y pixel data
            StarXBox.Text = ((double)XPosArr[StarSort[CurrentStarIndex]]).ToString("0");
            StarYBox.Text = ((double)YPosArr[StarSort[CurrentStarIndex]]).ToString("0");

            //Convert X,Y coordinates to RA,Dec coordinates
            double cerr = tsximg.XYToRADec((double)XPosArr[StarSort[CurrentStarIndex]], (double)YPosArr[StarSort[CurrentStarIndex]]);
            RAstar = tsximg.XYToRADecResultRA();
            Decstar = tsximg.XYToRADecResultDec();
            StarRABox.Text = RAstar.ToString("0.00");
            StarDecBox.Text = Decstar.ToString("0.00");

            //Locate the star via starchart
            //LocateCenter();
            photoStar = LocateStar(RAstar, Decstar, (double)MagArr[StarSort[CurrentStarIndex]], 0);
            StarADUChart.Titles[0].Text = photoStar.Name;
            double catMag = photoStar.CatMagnitude;
            StarCatMagBox.Text = catMag.ToString("0.00");
            double instmag = (double)MagArr[StarSort[CurrentStarIndex]];
            StarInstMagBox.Text = instmag.ToString("0.00");
            double magzeropt = catMag - instmag;
            StarCatMagDeltaBox.Text = magzeropt.ToString("0.00");

            //Create the graph series for the 2XFWHM X range around X center, for the 2XFWHM Y range around the Y center
            //  making sure to cut off any excursion either below 0 or about the X or Y ranges
            //
            //So... for a 2XFWHM number of data series,
            int maxStarADU = 0;
            for (int i = 0; i < fwhmSpan; i++)
            {
                //Create a series object for the scanned line and attach it to the graph
                Ypix[i] = new Series(i.ToString());
                StarADUChart.Series.Add(Ypix[i]);
                //Scan in the } data series from the image, if it runs over the range, presumably it will truncate normally
                int lineIndex = (int)(i + YCen - (fwhmSpan / 2));
                if (lineIndex >= 0 && lineIndex < YMax)
                {
                    Yline = tsximg.scanLine(lineIndex);
                    //Write the pixel values to the series while checking for saturation (indicate in the label).
                    //  and for the maximum ADU value

                    for (int j = Pix0; j <= PixN; j++)
                    {
                        if (j < Yline.Length)
                        {
                            int adu = (int)Yline[j];
                            if (adu > maxStarADU) maxStarADU = adu;
                            Ypix[i].Points.Add(adu * PixelScale_arcsec);
                        }
                    }
                }

                //Set the chart configuration and display
                Ypix[i].XValueType = ChartValueType.Auto;
                Ypix[i].ChartType = SeriesChartType.SplineArea;
                Ypix[i].MarkerStyle = MarkerStyle.Circle;
            }
            //set the maximum ADU as the value at the center
            if (maxStarADU > SaturationADU)
            {
                MaxADULabel.ForeColor = Color.Black;
                MaxADULabel.BackColor = Color.Pink;
            }
            else
            {
                MaxADULabel.ForeColor = Color.White;
                MaxADULabel.BackColor = Color.Empty;
            }
            StarPeakADUBox.Text = maxStarADU.ToString("0");
            //All done
            return;
        }

        private void GraphMagnitudes()
        {
            //Graphs the ccd magnitude against the catalog magnitude

            List<double> sexMagPlotPoints = new List<double>();
            List<double> catMagPlotPoints = new List<double>();
            List<double> imgADUPlotPoints = new List<double>();
            List<Star> starPoints = new List<Star>();
            List<Star> validStarPoints = new List<Star>();

            double maxDimCatVal = 0;

            magArrPlotIndex = new List<int>();

            PhotometryChart.Series[0].Points.Clear();
            //PhotometryChart.Series[1].Points.Clear();

            //Display the total number of stars to analyze from the image light source arrays
            StarCountBox.Text = MagArr.Length.ToString("0");
            //Deconstruct each light source into
            //  1) image location -> greatest (or nearly greatest) ADU of star
            //  2) image location -> celestial location -> cataloged star -> cataloged magnitude
            //  3) cataloged magnitude / instrument magnitude -> most common mag ratio
            //Center up the star chart
            LocateCenter();
            Color savebackcolor = StarCountBox.BackColor;
            for (int sIdx = 0; sIdx < MagArr.Length; sIdx++)
            {
                //Use a count down of the star count as a progress bar
                StarCountBox.Text = (MagArr.Length - sIdx).ToString("0");
                //Get X,Y position of source on image
                int xPos = (int)(double)XPosArr[sIdx];
                int yPos = (int)(double)YPosArr[sIdx];
                if (CheckWCSActive((double)XPosArr[sIdx], (double)YPosArr[sIdx]))
                {
                    //Get ADU at image X,Y position
                    //  Note: the Zero Y line is the top line of the image
                    object[] xDataLine = tsximg.scanLine(yPos);
                    int xyADU = (int)xDataLine[xPos];
                    int cerr = tsximg.XYToRADec(xPos, yPos);
                    //Get the cestial location by translating X,Y position to RA,Dec position 
                    cerr = tsximg.XYToRADec((double)XPosArr[sIdx], (double)YPosArr[sIdx]);
                    double RAstar = tsximg.XYToRADecResultRA();
                    double Decstar = tsximg.XYToRADecResultDec();
                    //Look up the star at that location and
                    //  read in it's apparent magnitude
                    Star targetStar = LocateStar(RAstar, Decstar, (double)MagArr[sIdx], xyADU);
                    if (!targetStar.IsStar)
                        targetStar.CatMagnitude = targetStar.InstMagnitude;
                    else if (targetStar.CatMagnitude > maxDimCatVal)
                        maxDimCatVal = targetStar.CatMagnitude;
                    starPoints.Add(targetStar);
                    if (starPoints[starPoints.Count - 1].IsStar && starPoints[starPoints.Count - 1].ADU < SaturationADU) validStarPoints.Add(targetStar);
                }
            }

            //Create array of ratios of cat mag to ccd mag which are real stars and unsaturated
            double[] validMagRatioArray = new double[validStarPoints.Count];
            double[] validMagDeltaArray = new double[validStarPoints.Count];
            for (int i = 0; i < validStarPoints.Count; i++)
            {
                validMagRatioArray[i] = validStarPoints[i].CatMagnitude / validStarPoints[i].InstMagnitude;
                validMagDeltaArray[i] = validStarPoints[i].CatMagnitude - validStarPoints[i].InstMagnitude;
            }

            //Determine median cat/ccd ratio using the most "popular" value of a histogram of these stars
            double magRatio = 0;
            double magDelta = 0;
            if (validStarPoints.Count > 0)
            {
                magRatio = MagRatio(validMagRatioArray);
                magDelta = MagDelta(validMagDeltaArray);
            }
            //
            for (int sIdx = 0; sIdx < starPoints.Count; sIdx++)
            {
                bool isStar = starPoints[sIdx].IsStar;
                string starName = starPoints[sIdx].Name;
                double catMag = starPoints[sIdx].CatMagnitude;
                double sexMag;
                if (isStar) sexMag = starPoints[sIdx].InstMagnitude * magRatio;
                else sexMag = starPoints[sIdx].InstMagnitude;
                double xyADU = starPoints[sIdx].ADU;

                if (IsBetween(maxMagVal, catMag, minMagVal))
                {
                    sexMagPlotPoints.Add(sexMag);
                    catMagPlotPoints.Add(catMag);
                    imgADUPlotPoints.Add(xyADU);
                    magArrPlotIndex.Add(sIdx);
                    //get index for next point in graphed series
                    int pLast = PhotometryChart.Series[0].Points.Count;
                    //Add the next point to the graph
                    PhotometryChart.Series[0].Points.AddXY(catMag, sexMag);
                    //Color the point Dark green if GSC, green if UCAC, light green otherwise
                    switch (starName[0])
                    {
                        case 'G':
                            {
                                PhotometryChart.Series[0].Points[pLast].Color = Color.DarkGreen;
                                break;
                            }
                        case 'U':
                            {
                                PhotometryChart.Series[0].Points[pLast].Color = Color.Green;
                                break;
                            }
                        default:
                            {
                                PhotometryChart.Series[0].Points[pLast].Color = Color.LightGreen;
                                break;
                            }
                    }
                    //Recolor it red if saturated, blue if not
                    if (xyADU > SaturationADU)
                        PhotometryChart.Series[0].Points[pLast].Color = Color.Red;
                    if (!isStar)
                        PhotometryChart.Series[0].Points[pLast].Color = Color.LightBlue;
                }

            }
            //Reset the star count display to the number of light sources
            StarCountBox.BackColor = savebackcolor;
            StarCountBox.Text = starPoints.Count.ToString("0");
            int len = sexMagPlotPoints.Count;
            double[] catVals = new double[len];
            double[] sexVals = new double[len];
            double[] aduVals = new double[len];
            for (int i = 0; i < len; i++)
            {
                catVals[i] = catMagPlotPoints[i];
                sexVals[i] = sexMagPlotPoints[i];
                aduVals[i] = imgADUPlotPoints[i];
            }
            //setup a point count and increment for plotting the regression curves
            int lineCount = 20;
            double incr = (sexVals.Max() - sexVals.Min()) / (double)lineCount;
            Tuple<double, double> magCoor = MathNet.Numerics.Fit.Line(sexVals, catVals);
            //Plot mag/adu points
            for (int iPt = 0; iPt < lineCount; iPt++)
            {
                double x = (iPt * incr) + sexVals.Min();
                double y = magCoor.Item2 * x + magCoor.Item1;
            }
            double instMatLowerEnd = MagUpperEnd(sexVals, 100);
            //double upperCatEnd = MagUpperEnd(catVals, 100);
            double catMagLowerEnd = maxDimCatVal;

            CatLimitingMagBox.Text = catMagLowerEnd.ToString("0.00");
            InstLimitingMagBox.Text = instMatLowerEnd.ToString("0.00");
            MeanCatInstMagRatioBox.Text = magRatio.ToString("0.00");
            MeanCatInstMagDeltaBox.Text = magDelta.ToString("0.00");

            PhotometryChart.ChartAreas[0].AxisX.Interval = 1;
            PhotometryChart.ChartAreas[0].AxisY.Interval = 1;

            PhotometryChart.ChartAreas[0].AxisX.Maximum = Math.Ceiling(catVals.Max()) + 1;
            PhotometryChart.ChartAreas[0].AxisX.Minimum = Math.Floor(catVals.Min()) - 1;
            PhotometryChart.ChartAreas[0].AxisY.Maximum = Math.Ceiling(sexVals.Max()) + 1;
            PhotometryChart.ChartAreas[0].AxisY.Minimum = Math.Floor(sexVals.Min()) - 1;

            return;
        }

        private void AnalyzeSubframe()
        {

            double gain;          //electrons per ADU:  .37 for SBIG STF8000M, .87 for SBIG 11002
            double rnoise;        //read out noise in electrons: 9.3 for SBIG STF8300M, 11 for SBIG 11002
            double noisefac;      //maximum tolerable contribution of readout noise
                                  //double expfac ;       //Exposure reduction factor -- Not used at this time
            double slambda;       //Faint target ADU minimum
            double snrtgt;        //fraction of maximum achievable signal to noise ratio (Cannistra)

            gain = (double)GainBox.Value;                   //electrons per ADU:  .37 for SBIG STF8000M, .87 for SBIG 11002
            rnoise = (double)ReadNoiseBox.Value;              //read out noise in electrons: 9.3 for SBIG STF8300M, 11 for SBIG 11002
            noisefac = (double)MaxReadNoiseBox.Value / 100;       //maximum tolerable contribution of readout noise (%)
                                                                  // expfac  = ReductionBox.Value              //Exposure reduction factor -- Not used at this time
            slambda = (double)MinFaintADU.Value;        //Faint target ADU minimum
            snrtgt = (double)SNRPercentBox.Value;         //fraction of maximum achievable signal to noise ratio (Cannistra)

            int pedestal;    //base pedestal
            int px;
            int py;
            //int pxbin;
            //int pybin;

            double exptime;

            double avgADU;
            double esky;
            double torn;
            double totalErrorPerMinute;

            //Using FITS file information...
            Fits fit = new Fits(tsximg);

            pedestal = (int)fit.Pedistal;
            px = (int)fit.ImagePixWidth;
            py = (int)fit.ImagePixHeight;
            exptime = (double)fit.Exposure;

            px -= px;
            py -= py;

            avgADU = tsximg.averagePixelValue();
            totalErrorPerMinute = 60 * (avgADU / exptime);
            esky = ((avgADU + pedestal) * gain) / exptime;
            torn = Math.Pow(rnoise, 2) / (((Math.Pow((1 + noisefac), 2) - 1) * esky));

            double smithExp = (torn / 2);
            //double antseyTotalExp = (slambda * Math.Sqrt((double)SessionMinutesBox.Value)) / (2 * Math.Sqrt(avgADU / exptime));
            double antseyTotalExp = (slambda * Math.Sqrt((double)SessionHoursBox.Value * 60)) / (2 * Math.Sqrt(totalErrorPerMinute));
            double antseyFramesExp = Math.Pow(slambda, 2) * (double)TotalFrames.Value / (4 * totalErrorPerMinute);
            double canestraExp = (Math.Pow(snrtgt, 2) * Math.Pow(rnoise, 2)) / ((esky) * (1 - Math.Pow(snrtgt, 2)));

            SmExpLabel.Text = (smithExp).ToString("0");
            CaExpLabel.Text = (canestraExp).ToString("0");
            AnExpTotalTimeLabel.Text = (antseyTotalExp * 60).ToString("0");
            AntseyTotalFramesLabel.Text = (antseyFramesExp * 60).ToString("0");

            return;
        }

        private void ArchiveStar()
        {
            //Method to store star mag for future reference
            Starchive photoSave = new Starchive();
            photoSave.SetPhotometry(photoStar.Name, Convert.ToDateTime(fit.FitsDate), fit.Filter, photoStar.InstMagnitude, Convert.ToDouble(MeanCatInstMagDeltaBox.Text));
            return;
        }

        private void PlotPhotometryHistory()
        {
            //Plots out history of current star photometry
            Starchive pHistory = new Starchive();
            PhotoStarBox.Text = photoStar.Name;
            PhotoFilterBox.Text = fit.Filter;
            List<Starchive.PhotoData> photoList = pHistory.GetPhotometry(photoStar.Name, fit.Filter);
            this.VariationGraph.Series[0].Points.Clear();
            foreach (Starchive.PhotoData photo in photoList)
            {
                //Star Mag is the computed Inst Mag for star in the archived image
                //MagScale is Mean Ratio of Catalog Mag to Inst Mag for the archived image
                VariationGraph.Series[0].Points.AddXY((photo.StarInstMag + photo.StarMagDelta), photo.StarDate);
            }
            return;
        }

        private void LocateCenter()
        {
            sky6StarChart tsxsc = new sky6StarChart();
            //sky6ObjectInformation tsxod = new sky6ObjectInformation();
            sky6Utils tsxut = new sky6Utils();

            //Ultimately, we want to center the star chart on the FOV of the image,
            //  but not resize the chart
            tsxut.ConvertStringToRA(tsximg.FITSKeyword("OBJCTRA"));
            double RACen = tsxut.dOut0;
            tsxut.ConvertStringToDec(tsximg.FITSKeyword("OBJCTDEC"));
            double DecCen = tsxut.dOut0;
            tsxsc.RightAscension = RACen;
            tsxsc.Declination = DecCen;
            Xcen = tsxsc.WidthInPixels / 2;
            Ycen = tsxsc.HeightInPixels / 2;
        }

        /// <summary>
        /// Determines the closest catalog star to the input ra/dec.  
        /// </summary>
        /// <param name="raStar"></param>
        /// <param name="decStar"></param>
        /// <param name="instMag"></param>
        /// <param name="aduVal"></param>
        /// <returns>Star structure</returns>
        private Star LocateStar(double raStar, double decStar, double instMag, double aduVal)
        {
            //Find the star on the chart then access it's object information, in particular for apparent magnitude
            //Create new star structure
            Star star = new Star()
            {
                RAfromImage = raStar,
                DecfromImage = decStar
            };

            sky6StarChart tsxsc = new sky6StarChart();
            sky6ObjectInformation tsxod = new sky6ObjectInformation();
            //sky6Utils tsxut = new sky6Utils();

            //Ultimately, we want to center the star chart on the FOV of the image,
            //  but not resize the chart

            ////Center the star chart on the RA/Dec coordinates
            //tsxsc.RightAscension = raStar;
            //tsxsc.Declination = decStar;
            //System.Threading.Thread.Sleep(1); //give TSX a chance to update
            // tsxsc.ClickFind((int)Xcen, (int)Ycen);
            tsxsc.EquatorialToStarChartXY(raStar, decStar);
            int xC = (int)tsxsc.dOut0;
            int yC = (int)tsxsc.dOut1;
            tsxsc.ClickFind(xC, yC);
            tsxod.Property(TheSky64Lib.Sk6ObjectInformationProperty.sk6ObjInfoProp_NAME1);
            string name1 = tsxod.ObjInfoPropOut;
            //tsxod.Property(TheSky64Lib.Sk6ObjectInformationProperty.sk6ObjInfoProp_NAME2);
            //string name2 = tsxod.ObjInfoPropOut;
            //tsxod.Property(TheSky64Lib.Sk6ObjectInformationProperty.sk6ObjInfoProp_NAME3);
            //string name3 = tsxod.ObjInfoPropOut;
            star.Name = name1;

            tsxod.Property(TheSky64Lib.Sk6ObjectInformationProperty.sk6ObjInfoProp_MAG);
            star.CatMagnitude = tsxod.ObjInfoPropOut;
            star.InstMagnitude = instMag;
            star.ADU = aduVal;
            //Add RA Dec coordinates to name if from GAIA and APASS catalog
            star.IsStar = true;
            if (star.Name.Contains("Gaia"))
                star.Name = Utilities.CreateGaiaStarLabel(star.RAfromImage, star.DecfromImage);
            if (star.Name.Contains("APASS"))
                star.Name = Utilities.CreateGaiaStarLabel(star.RAfromImage, star.DecfromImage);
            if (star.Name.Contains("Mouse"))
                star.IsStar = false;
            return (star);
        }

        private bool CheckWCSActive(double xpos, double ypos)
        {
            //Determines if a star in the location xpos, ypos got used for image linking
            //  returns if it was
            for (int i = 0; i < WCSActiveArr.Length; i++)
            { if ((int)(double)WCSActiveArr[i] == 1 && Near((double)WCSXPosArr[i], xpos) && Near((double)WCSYPosArr[i], (int)ypos)) return true; }
            return false;
        }

        /// <summary>
        ///Seeing calculator based on aperature and FWHM, using Canadian Weather Service table
        ///FWHM is adjusted proportionally to a 12" aperture, gauged against the Canadian seeing table values
        ///FWHM is in units of arcsec
        ///apertrue is in units of mm
        /// </summary>
        /// <param name="FWHM"></param>
        /// <param name="aperture"></param>
        /// <returns></returns>
        private string GetSeeingClass(double FWHM, double aperture)
        {
            double apadj = 12 / (aperture / 25.4);
            if (FWHM < (0.4 * apadj)) return ("V (Excellent)");
            else if (FWHM < (1.0 * apadj)) return ("IV (Good)");
            else if (FWHM < (2.5 * apadj)) return ("III (Average)");
            else if (FWHM < (4.0 * apadj)) return ("II (Poor)");
            else return ("I (Bad)");
        }

        private double MagRatio(double[] validStarMagRatios)
        {
            //take a histogram of that array (100 buckets)
            MathNet.Numerics.Statistics.Histogram magHist = new MathNet.Numerics.Statistics.Histogram(validStarMagRatios, 100);
            //Find the bucket with the largest count
            int maxBucketIndex = 0;
            for (int i = 0; i < magHist.BucketCount; i++) if (magHist[i].Count > magHist[maxBucketIndex].Count) maxBucketIndex = i;
            //Assign the average of the upper and lower bounds of that bucket to be the best average cat/ccd ratio
            double magRatio = (magHist[maxBucketIndex].UpperBound + magHist[maxBucketIndex].LowerBound) / 2.0;
            return magRatio;
        }
        private double MagDelta(double[] validStarMagDeltas)
        {
            //take a histogram of that array (100 buckets)
            MathNet.Numerics.Statistics.Histogram magHist = new MathNet.Numerics.Statistics.Histogram(validStarMagDeltas, 100);
            //Find the bucket with the largest count
            int maxBucketIndex = 0;
            for (int i = 0; i < magHist.BucketCount; i++) if (magHist[i].Count > magHist[maxBucketIndex].Count) maxBucketIndex = i;
            //Assign the average of the upper and lower bounds of that bucket to be the best average cat/ccd ratio
            double magDelta = (magHist[maxBucketIndex].UpperBound + magHist[maxBucketIndex].LowerBound) / 2.0;
            return magDelta;
        }


        /// <summary>
        /// Returns true if b is between a and c, inclusive
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private bool IsBetween(double a, double b, double c)
        {
            if (a <= c && a <= b && b <= c) return true;
            else if (a >= c && a >= b && b >= c) return true;
            else return false;
        }

        private double MagUpperEnd(double[] magData, int buckets)
        {
            IEnumerable<double> magdataEnum = magData;
            double[] histData = new double[buckets];
            MathNet.Numerics.Statistics.Histogram hist = new MathNet.Numerics.Statistics.Histogram(magdataEnum, buckets);
            double threshhold = hist.DataCount / 40;
            for (int i = buckets - 1; i >= 0; i--)
                if (hist[i].Count > threshhold)
                    return hist[i].UpperBound;
            return 0;
        }

        #region Conversions
        private double ConvertToArcSec(double microns, double focalLength)
        {
            return 206.256 * microns / focalLength;

        }

        private double ConvertToMicrons(double arcSec, double focalLength)
        {
            return arcSec * focalLength / 206.256;

        }

        private bool Near(double x, double y)
        {
            if (Math.Abs(x - y) < 1)
                return true;
            else return false;
        }
        #endregion

        #region starclass

        public class Star
        {
            //Structure for handling star data after look up
            public string Name { get; set; }
            public double CatMagnitude { get; set; }
            public double InstMagnitude { get; set; }
            public double ADU { get; set; }
            public bool IsStar { get; set; }
            public double RAfromImage { get; set; }
            public double DecfromImage { get; set; }

            public Star() { }
        }

        #endregion

        #region clickevents

        private void NextButton_Click(object sender, EventArgs e)
        {
            //} Button:  Graphs the } lower magnitude light source, if any
            //Increment the global sort index (if not the last) { graph that star
            NextStar();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //Back Button:  Graphs the } higher magnitude light source, if any
            //Decrement the global sort index (if not the first) { graph that star
            PriorStar();
        }

        private void OpenFitsButton_Click(object sender, EventArgs e)
        {
            FitsFileManager.CloseFitsFile(tsximg);
            FitsIsOpen = FitsFileManager.OpenFitsFile(tsximg);
            OpenFileNameBox.Text = tsximg.Path;
            if (FitsIsOpen) Analyze();
            return;
        }

        private void AttachButton_Click(object sender, EventArgs e)
        {
            //Attach to current active image in TSX, if any -- prompt if not
            FitsIsOpen = FitsFileManager.AttachFitsFile(tsximg);
            if (FitsIsOpen) 
                Analyze();
        }

        private double MeanDifference(double[] a, double[] b)
        {
            double[] c = new double[a.Length];
            for (int i = 0; i < a.Length; i++) c[i] = a[i] - b[i];
            return MathNet.Numerics.Statistics.Statistics.Mean(c);
        }

        private void PhotometryChart_MouseClick(object sender, MouseEventArgs e)
        {
            //Plot the graph of the star selected by the mouse click
            //  and search for any archived instances to plot in the timeline graph

            //Get the location of the click in terms of its index in the point array
            HitTestResult htr = PhotometryChart.HitTest(e.X, e.Y);
            //First, check to make sure this is a real data point and not something else?
            if (htr.ChartElementType == ChartElementType.DataPoint)
            {
                //Get the index
                int pIndex = htr.PointIndex;
                //Get the index for this point in the mag plot array
                int mIndex = magArrPlotIndex[pIndex];
                //Find that mag index in the sort array
                CurrentStarIndex = Array.FindIndex(StarSort, w => w == mIndex);
                GraphStar();
                ArchiveStar();
                PlotPhotometryHistory();
            }
        }

        private void OnTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Sets the window to stay on top... or not
            this.TopMost = OnTopCheckBox.Checked;
        }

        private void ReadMeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(seeinginst);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //Close out the application
            FitsFileManager.CloseFitsFile(tsximg);
            Properties.Settings.Default.Save();
            Close();
            return;
        }

        private void RecalculateButton_Click(object sender, EventArgs e)
        {
            if (FitsIsOpen) AnalyzeSubframe();
        }

        #endregion

        #region value changes

        private void SessionHoursBox_ValueChanged(object sender, EventArgs e)
        {
            if (!initFlag) Properties.Settings.Default.SessionHours = (double)SessionHoursBox.Value;
            if (FitsIsOpen) AnalyzeSubframe();
        }

        private void GainBox_ValueChanged(object sender, EventArgs e)
        {
            if (!initFlag) Properties.Settings.Default.Egain = (double)GainBox.Value;
            if (FitsIsOpen) AnalyzeSubframe();
        }

        private void RNoiseBox_ValueChanged(object sender, EventArgs e)
        {
            if (!initFlag) Properties.Settings.Default.ReadNoise = (double)ReadNoiseBox.Value;
            if (FitsIsOpen) AnalyzeSubframe();
        }

        private void MaxNoiseBox_ValueChanged(object sender, EventArgs e)
        {
            if (!initFlag) Properties.Settings.Default.MaxReadNoise = (double)MaxReadNoiseBox.Value;
            if (FitsIsOpen) AnalyzeSubframe();
        }

        private void MinFaintADU_ValueChanged(object sender, EventArgs e)
        {
            if (!initFlag) Properties.Settings.Default.MinFaintADU = (int)MinFaintADU.Value;
            if (FitsIsOpen) AnalyzeSubframe();
        }

        private void SNRTgtBox_ValueChanged(object sender, EventArgs e)
        {
            if (!initFlag) Properties.Settings.Default.SNR_Percent = (double)SNRPercentBox.Value;
            if (FitsIsOpen) AnalyzeSubframe();
        }

        private void TotalFrames_ValueChanged(object sender, EventArgs e)
        {
            if (!initFlag) Properties.Settings.Default.AntseyFrameCount = (double)TotalFrames.Value;
            if (FitsIsOpen) AnalyzeSubframe();
        }


        #endregion

        private void OverviewButton_Click(object sender, EventArgs e)
        {

        }

        private void OpenFileNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CullButton_Click(object sender, EventArgs e)
        {
            Starchive sc = new Starchive();
            sc.ClearPhotometry(photoStar.Name);
        }
    }

}

