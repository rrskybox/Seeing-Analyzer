using System;
using TheSky64Lib;

namespace Seeing_Analyzer
{
    public class Fits
    {
        public double? PixSize { get; set; }
        public double? Gain { get; set; }
        public double? Aperture { get; set; }
        public double? FocalLength { get; set; }
        public double? Exposure { get; set; }
        public string Filter { get; set; }
        public int? PixBits { get; set; }
        public int? ImagePixWidth { get; set; }
        public int? ImagePixHeight { get; set; }
        public int? BinX { get; set; }
        public int? BinY { get; set; }
        public int? Pedistal { get; set; }
        public string FitsTarget { get; set; }
        public string FitsDate { get; set; }
        public string FitsTime { get; set; }


        public Fits(ccdsoftImage tsximg)
        {
            //Using FITS file information...
            //Compute pixel scale = 206.256 * pixel size (in microns) / focal length
            //FitsTarget = tsximg.FITSKeyword("OBJECT") ?? "None";
            FitsTarget = GetFitsString(tsximg, "OBJECT");
            string[] fitsTime = (GetFitsString(tsximg, "LOCALTIM")).Split(' ');
            if (fitsTime.Length > 2)
            {
                FitsDate = fitsTime[0];
                FitsTime = fitsTime[1] + fitsTime[2];
            }
            else
            {
                FitsDate = DateTime.Now.ToString("d");
                FitsTime = DateTime.Now.ToString("t");
            }
            PixSize = GetFits(tsximg, "XPIXSZ");
            PixSize = GetFits(tsximg, "XPIXELSZ") ?? PixSize;
            Gain = GetFits(tsximg, "EGAIN");
            FocalLength = GetFits(tsximg, "FOCALLEN");
            Aperture = GetFits(tsximg, "APTDIA");
            Exposure = GetFits(tsximg, "EXPTIME");
            Filter = GetFitsString(tsximg, "FILTER");
            PixBits = (int)GetFits(tsximg, "BITPIX");
            ImagePixWidth = (int)(tsximg.FITSKeyword("NAXIS1") ?? 0);
            ImagePixHeight = (int)(tsximg.FITSKeyword("NAXIS2") ?? 0);
            BinX = (int)tsximg.FITSKeyword("XBINNING");
            BinY = (int)tsximg.FITSKeyword("YBINNING");
            try { Pedistal = (int)(tsximg.FITSKeyword("PEDISTAL") ?? 0); }
            catch { Pedistal = 0; }
        }

        private double? GetFits(ccdsoftImage tsximg, string keyWord)
        {
            double? keyValue;
            try { keyValue = tsximg.FITSKeyword(keyWord); }
            catch { return null; }
            return keyValue;
        }
        private string GetFitsString(ccdsoftImage tsximg, string keyWord)
        {
            string keyValue;
            try { keyValue = tsximg.FITSKeyword(keyWord); }
            catch { return "None"; }
            return keyValue;
        }
        private int GetFitsInteger(ccdsoftImage tsximg, string keyWord)
        {
            int keyValue;
            try { keyValue = tsximg.FITSKeyword(keyWord); }
            catch { return 0; }
            return keyValue;
        }

    }
}
