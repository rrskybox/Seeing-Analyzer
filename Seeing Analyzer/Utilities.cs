namespace Seeing_Analyzer
{
    public class Utilities
    {
        public static string CreateGaiaStarLabel(double RA, double Dec)
        {
            //Creates a name for a blank "Gaia" star
            return ("GAIA " + RA.ToString() + " " + Dec.ToString());
        }
    }
}
