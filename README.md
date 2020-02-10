# Seeing-Analyzer
Tool for extraction of seeing (scintillation) effects from stellar images using TheSkyX.

Seeing Analyzer Description

This Windows Form applet uses the TSX Image Link functions to analyze star astrometry to calculate the seeing conditions at the time the image was taken -- normally a current image. The image of each individual star that is detected is also displayed in a 3D graphical image for visual consideration of diffusion and focus artifacts.

Requirements:  

Seeing Analyzer is a Windows Forms executable, written in Visual Basic.  The application runs as an uncertified, standalone application under Windows 7, 8 and 10.  The application uses the TSX Camera Add On capability.

Installation:  

Download the SeeingAnalyzer_Exe.zip and open.  Run the "Setup" application.  Upon completion, an application icon will have been added to the start menu under the category "TSXToolkit" with the name 
“Seeing Analyzer".  This application can be pinned to the Start if desired.

Operation:  

The current image in TSX is activated and FITS information acquired.  The image is then sent through image link to compute WCS information for each star.  The results are sorted by magnitude, averaged, seeing estimated and results displayed.

Support:  

This application was written for the public domain and as such is unsupported. The developer wishes you his best and hopes everything works out, but recommends learning Visual Basic (it's really not hard and the tools are free from Microsoft) if you find a problem or want to add features.  The source is supplied as a Visual Studio project.
