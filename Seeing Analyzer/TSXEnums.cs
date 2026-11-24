namespace Seeing_Analyzer
{
    public class TSXEnums
    {

        public enum ccdsoftInventoryIndex
        {
            cdInventoryX,
            cdInventoryY,
            cdInventoryMagnitude,
            cdInventoryClass,
            cdInventoryFWHM,
            cdInventoryMajorAxis,
            cdInventoryMinorAxis,
            cdInventoryTheta,
            cdInventoryEllipticity
        }

        public enum ccdsoftWCSIndex
        {
            cdWCSRA,
            cdWCSDec,
            cdWCSX,
            cdWCSY,
            cdWCSPositionError,
            cdWCSResidual,
            cdWCSCatalogID,
            cdActive
        }

        public enum ccdsoftAutoContrastMethod
        {
            cdAutoContrastUseAppSetting = -1,
            cdAutoContrastSBIG,
            cdAutoContrastBjorn,
            cdAutoContrastDSS100X,
        }

        public enum ccdsoftBjornBackground
        {
            cdBgNone,
            cdBgWeak,
            cdBgMedium,
            cdBgStrong,
            cdBgVeryStrong
        }

        public enum ccdsoftBjornHighlight
        {
            cdHLNone,
            cdHLWeak,
            cdHLMedium,
            cdHLStrong,
            cdHLVeryStrong,
            cdHLAdaptive,
            cdHLPlanetary
        }

        public enum ccdsoftCoordinates
        {
            cdRA,
            cdDec
        }

        public enum ccdsoftSaveAs
        {
            cdGIF,
            cdBMP,
            cdJPG,
            cd48BitTIF

        }
    }
}
