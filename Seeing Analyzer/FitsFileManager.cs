using System;
using System.Windows.Forms;
using TheSky64Lib;

//Static class for opening fits files inside of TSX

namespace Seeing_Analyzer
{
    public static class FitsFileManager
    {

        public static bool OpenFitsFile(ccdsoftImage tsximg)
        {
            using (OpenFileDialog fitsDialog = new OpenFileDialog())
            {
                fitsDialog.Filter = "*.fit|*.fit";
                if (fitsDialog.ShowDialog() == DialogResult.OK)
                {
                    tsximg.Path = fitsDialog.FileName;
                    try { tsximg.Open(); }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                    return true;
                }
                else return false;
            }
        }

        public static bool AttachFitsFile(ccdsoftImage tsximg)
        {
            try { tsximg.AttachToActive(); }
            catch (Exception ex)
            {
                MessageBox.Show("No active image found in TSX: " + ex.Message);
                return false;
            }
            return true;
        }

        public static void CloseFitsFile(ccdsoftImage tsximg)
        {
            try { tsximg.Close(); }
            catch { return; };
            return;
        }

    }
}
