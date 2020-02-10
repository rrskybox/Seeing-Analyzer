' --------------------------------------------------------------------------------
' TSX Helper Applet for analyzing seeing conditions from an image using ImageLink
''
' Description:	This Windows Form applet uses the TSX Image Link functions to analyze star 
'               astrometry to calculate the seeing conditions at the time the
'               image was taken -- normally a current image.
'               The image of each individual star that is detected is also displayed
'               in a 3D graphical image for visual consideration of diffusion and focus
'               artifacts.
'
' Environment:  Windows 7,8,10 executable, 32 and 64 bit
'
' Usage:        See the "Explanation" Region below
'
' Author:		(REM) Rick McAlister, rrskybox@yahoo.com
'
' Edit Log:     Rev 1.0 Initial Version
'               Rev 1.1
'               Rev 1.2 Updated XYToRADec method
'                       Fixed a bug where I left in a stub for a DSS issue
'                       Changed Inst Mag to Mag Zero Pt Offset which is how far off
'                           the TSX Magnitude Zero Point setting is from where it should be.
'
' Date			Who	Vers	Description
' -----------	---	-----	-------------------------------------------------------
' 02-18-2015	REM	1.0.0	Initial version
' 08-12-2017    REM 1.2.1   Fixes above
' ---------------------------------------------------------------------------------
'

Imports System.Windows.Forms.DataVisualization.Charting

Public Class SeeingProfiler

#Region "Explanation"

    Public Const seeinginst = "Seeing Profiler Instructions: " + vbCrLf + vbCrLf +
        "This applet extracts atmospheric seeing qualities from a TSX image-linked picture," + vbCrLf +
        "  and produces a graphical plot of the intensity for each star recognized" + vbCrLf +
        "  in that image. This applet is based largly on the work of Bruce MacEvoy," + vbCrLf +
        " Bruce MacEvoy: www.handprint.com/ASTRO/seeing1.html and www.handprint.com/ASTRO/seeing2.html." + vbCrLf +
        vbCrLf +
        "The Seeing qualities computed from the FITS information and image-linking are: " + vbCrLf +
        "  1. Resolution of camera in arcsecs (based on telescope and camera parameters) " + vbCrLf +
        "  2. Airy disk in arcsec (based on telescope and camera parameters) " + vbCrLf +
        "  3. Seeing in arcsec (based on resolution and average FWHM of image stars) " + vbCrLf +
        "  4. Seeing Class based on Seeing and Aperture" + vbCrLf +
        "     (Environment Canada Seeing Forecast scale: http://weather.gc.ca/astro/seeing_e.html)" + vbCrLf +
        vbCrLf +
        "For each star in the recognized set (ordered by decreasing magnitude), a 3D graph" + vbCrLf +
        "  of twice the FWHM area of the star, based on pixel intensity and displayed with" + vbCrLf +
        "  the following parameters: " + vbCrLf +
        "  1. Relative instrument magnitude " + vbCrLf +
        "  2. FWHM (as computed by in pixels) " + vbCrLf +
        "  3. Ellipsity (as computed by TSX) " + vbCrLf +
        "  4. X,Y position (in pixels) " + vbCrLf +
        vbCrLf +
        "And, the routine uses the Star Chart to identify the star at the source's" + vbCrLf +
        "  location as determined by the image linking.  The Star Chart is centered" + vbCrLf +
        "  on the image with that specific star identified. " + vbCrLf +
        vbCrLf +
        "Prerequisites:  For the applet to work correctly, the following is required: " + vbCrLf +
        "  1. TSX Telescope properties (aperture, etc) must be entered correctly. " + vbCrLf +
        "  2. TSX Camera properties (scale, etc) must be entered correctly. " + vbCrLf +
        "  3. TSX must be running with an active image.  The image must be" + vbCrLf +
        "     able to be successfully image-linked without using All-Sky. " + vbCrLf +
        "  4. TSX ImageLink All-Sky tab must have 'Use All Sky ImageLink for scripted ImageLink' unchecked." + vbCrLf +
        vbCrLf +
        "Note:  Seeing results are most accurate if no image star is saturated or of magnitude brighter than 1." + vbCrLf

#End Region

    Public tsximg As Object
    Public tsxilk As Object

    Public StarSort() As Integer
    Public StarSortId As Integer

    Public FWHMArr() As Object
    Public EllipseArr() As Object
    Public XPosArr() As Object
    Public YPosArr() As Object
    Public MagArr() As Object

    Public MaxPix As Integer

    Private Sub SeeingAnalyzer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Upon load -- Move along, nothing to see here...
        Return
    End Sub

    Private Sub ReadMeButton_Click(sender As Object, e As EventArgs) Handles ReadMeButton.Click
        'Display the user instructions above
        MsgBox(seeinginst)
        Return
    End Sub

    Private Sub AnalyzeButton_Click(sender As Object, e As EventArgs) Handles AnalyzeButton.Click
        'This is the primary routine.  The current image in TSX is activated and FITS information acquired.
        '  The image is then sent through image link to compute WCS information for each star.
        '  The results are sorted by magnitude, averaged, seeing estimated and results displayed.
        '

        Dim ferr As Integer

        tsximg = CreateObject("TheSkyX.ccdsoftImage")
        tsxilk = CreateObject("TheSkyX.ImageLink")

        'Attach to current active image in TSX, if any -- prompt if not
        Try
            ferr = tsximg.AttachToActive()
        Catch ex As Exception
            MsgBox("No active image found in TSX.")
            Return
        End Try

        'Using FITS file information...
        'Compute pixel scale = 206.256 * pixel size (in microns) / focal length
        Dim pixsize As Double = 10 'Initial value in case the FITS words aren't there
        Try
            pixsize = tsximg.FITSKeyWord("XPIXSZ")
        Catch ex As Exception
            'do nothing, this is probably because the DSS image is being used
        End Try
        Try
            pixsize = tsximg.FITSKeyWord("XPIXELSZ")
        Catch ex As Exception
            'do nothing, this is probably because a regular image is being used
        End Try

        Dim foclen = 2563
        Dim aperture = 10
        Try
            foclen = tsximg.FITSKeyWord("FOCALLEN")
        Catch ex As Exception
            MsgBox("Focal Length was not set for this FITS image: defaulting to 2000 mm")
            foclen = 2000
        End Try
        'Compute Airy Disk = 2.76 / aperture (in inches)
        Try
            aperture = tsximg.FITSKeyword("APTDIA") / 25.4 'in inches
        Catch ex As Exception
            MsgBox("Aperture was not set for this FITS image: defaulting to 254 mm")
            aperture = 10
        End Try

        Dim airydisk = 2.76 / aperture

        'Compute pixel scale (arc sec per pixel) = 206.256 * scale / focal length
        '  focal length must be set to correct value in FITS header -- comes from camera set up in TSX
        Dim pixelarcsec = 206.256 * pixsize / foclen
        'Dim pixelarcsec = 206.256 * pixsize / 2563
    
        'Set the pixel scale for an InsertWCS image linking
        tsximg.ScaleInArcsecondsPerPixel = pixelarcsec

        'ImageLink for light sources (Insert WCS)
        Try
            ferr = tsximg.InsertWCS(True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Collect astrometric light source data from the image linking into single index arrays: 
        '  magnitude, fmhm, ellipsicity, x and y position
        MagArr = tsximg.InventoryArray(ccdsoftInventoryIndex.cdInventoryMagnitude)  'Magnitude, we think
        FWHMArr = tsximg.InventoryArray(ccdsoftInventoryIndex.cdInventoryFWHM) 'FMHW, we think
        EllipseArr = tsximg.InventoryArray(ccdsoftInventoryIndex.cdInventoryEllipticity) 'Ellipsity, we think
        XPosArr = tsximg.InventoryArray(ccdsoftInventoryIndex.cdInventoryX) 'X position, we think
        YPosArr = tsximg.InventoryArray(ccdsoftInventoryIndex.cdInventoryY) 'Y position, we think

        'Fill in Seeing Analysis information in the windows form: 
        '   Resolution, Airy Disk size, Seeing as FWHM average measurement, Seeing as set on the Canadian scale
        ResolutionLabel.Text = "Resolution (ArcSec/PIx) = " + Str(Math.Round(tsximg.ScaleInArcsecondsPerPixel, 2))
        AiryDiskLabel.Text = "Airy Disk = " + Str(Math.Round(airydisk, 2))
        Dim FWHMAvg As Double = 0
        For i = 0 To FWHMArr.Length - 1
            FWHMAvg = FWHMAvg + FWHMArr(i)
        Next
        FWHMAvg = FWHMAvg / FWHMArr.Length
        FWHMAvg = FWHMAvg * tsximg.ScaleInArcsecondsPerPixel
        SeeingLabel.Text = "Seeing = " + Str(Math.Round(FWHMAvg, 2))
        SeeingClassLabel.Text = "Seeing Class = " + GetSeeingClass(FWHMAvg, aperture)

        'Create sorted index of stars, based on magnitude, high to low
        'Generate initial ordered array
        ReDim StarSort(MagArr.Length - 1)
        For fi = 0 To StarSort.Length - 1
            StarSort(fi) = fi
        Next

        'Create an index table (StarSort) through which index pointers to the light source data arrays can be arranged
        '  Sort the index pointers in StarSort in the order of decreasing magnitude of the light source data
        '  using a simple bubble sort algorithm: exchange the place of each successive pair of index pointers until
        '  the magnitudes that they point to go from larger to smaller, in order.

        'Loop: until the flag remains false for an entire progression through the sort array, that is:
        ' Start loop
        '  Set sort flag to false (to indicate no exchange has occurred)
        '  For each sucessive pair of magnitudes, swap their position index pointers if the first is less than the second, and set flag true
        '  Continue through the index pointer list.
        '  Do it again until no swaps occur (flag is false)

        Dim bubbleflag As Boolean
        Dim temp As Integer
        Do
            bubbleflag = True
            For fi = 1 To StarSort.Length - 1
                If MagArr(StarSort(fi - 1)) > MagArr(StarSort(fi)) Then
                    temp = StarSort(fi - 1)
                    StarSort(fi - 1) = StarSort(fi)
                    StarSort(fi) = temp
                    bubbleflag = False
                End If
            Next
        Loop Until bubbleflag

        'check the sorting
        For fi = 1 To StarSort.Length - 1
            If MagArr(StarSort(fi - 1)) > MagArr(StarSort(fi)) Then
                MsgBox("bad order at " + Str(fi))
            End If
        Next

        'Set the global sort array index to the first (greatest magnitude) entry.
        StarSortId = 0
        'Graph 10x10 pixel area of star
        GraphStar(StarSortId)
        'Done
        Return

    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        'Next Button:  Graphs the next lower magnitude light source, if any
        'Increment the global sort index (if not the last) then graph that star

        'Test for active image
        Dim serr As Integer
        Try
            serr = StarSort.Length
        Catch ex As Exception
            MsgBox("No active image.")
            Return
        End Try

        StarSortId = StarSortId + 1
        If StarSortId < StarSort.Length Then
            GraphStar(StarSortId)  'Graph pixel area of star
        Else
            StarSortId = StarSort.Length - 1
            Return
        End If

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Back Button:  Graphs the next higher magnitude light source, if any
        'Decrement the global sort index (if not the first) then graph that star

        'Test for active image
        Dim serr As Integer
        Try
            serr = StarSort.Length
        Catch ex As Exception
            MsgBox("No active image.")
            Return
        End Try

        StarSortId = StarSortId - 1
        If StarSortId >= 0 Then
            GraphStar(StarSortId)  'Graph pixel area of star
        Else
            StarSortId = 0
            Return
        End If

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

        'Close out the application
        Close()
        Return
    End Sub

    Private Sub GraphStar(StarSortId As Integer)
        'This routine produces a 3D graph of a star's astrometric information, from the center out to twice the FWHM radius.

        'Get the star center (x,y) and 2xFWHM (in pixels), as well as the maximum X and Y values

        Dim RAstar As Double
        Dim Decstar As Double

        Dim XMax = tsximg.WidthInPixels() - 1
        Dim YMax = tsximg.HeightInPixels() - 1
        Dim XCen = XPosArr(StarSort(StarSortId))
        'Dim YCen = YMax - YPosArr(StarSort(StarSortId))  'Stub for simulator
        Dim YCen = YPosArr(StarSort(StarSortId))
        Dim Width = FWHMArr(StarSort(StarSortId)) * 2

        'Calculate the lowest and highest X positions for twice the FWHM
        Dim Pix0 = XCen - (Width / 2)
        If Pix0 < 0 Then
            Pix0 = 0
        End If
        Dim PixN = XCen + (Width / 2)
        If PixN > XMax Then
            PixN = XMax
        End If

        Dim Ypix(Width) As Object
        Dim Yline(Width)

        MagChart.Series.Clear()
        SaturationLabel.BackColor = Color.Empty
        SaturationLabel.Text = ""
        FWHMLabel.Text = "FWHM = " + Str(Math.Round(FWHMArr(StarSort(StarSortId)), 2))
        EllipseLabel.Text = "Ellpse = " + Str(Math.Round(EllipseArr(StarSort(StarSortId)), 2))
        ResolutionLabel.Text = "Resolution (ArcSec/PIx) = " + Str(Math.Round(tsximg.ScaleInArcsecondsPerPixel, 2))

        'Display X and Y pixel data
        XLabel.Text = "X = " + Str(Int(XPosArr(StarSort(StarSortId))))
        YLabel.Text = "Y = " + Str(Int(YPosArr(StarSort(StarSortId))))

        'Convert X,Y coordinates to RA,Dec coordinates
        Dim cerr = tsximg.XYToRADec(XPosArr(StarSort(StarSortId)), YPosArr(StarSort(StarSortId)))
        RAstar = tsximg.XYToRADecResultRA()
        Decstar = tsximg.XYToRADecResultDec()
        RALabel.Text = "RA = " + Str(Math.Round(RAstar, 2))
        DecLabel.Text = "Dec = " + Str(Math.Round(Decstar, 2))

        'Locate the star via starchart
        Dim actmag As Double = LocateStar(RAstar, Decstar)
        ActMagLabel.Text = "Act Mag =  " + Str(Math.Round(actmag, 2))
        Dim instmag As Double = MagArr(StarSort(StarSortId))
        Dim magzeropt As Double = actmag - instmag
        MagZeroPtLabel.Text = "Mag Zero Pt Offset = " + Str(Math.Round(magzeropt, 2))

        'Set the global value for the maximum pixel (used for determine staturation) at 95% of maximum ADU
        Dim MaxPix = (2 ^ tsximg.FITSKeyWord("BITPIX")) * 0.91

        'Create the graph series for the 2XFWHM X range around X center, for the 2XFWHM Y range around the Y center
        '  making sure to cut off any excursion either below 0 or about the X or Y ranges
        '
        'So... for a 2XFWHM number of data series,
        For i = 0 To Width - 1
            'Create a series object and attach it to the graph
            Ypix(i) = New Series(Str(i))
            MagChart.Series.Add(Ypix(i))
            'Scan in the next data series from the image, if it runs over the range, presumably it will truncate normally
            Yline = tsximg.scanline(i + YCen - (Width / 2))
            'Write the pixel values to the series while checking for saturation (indicate in the label).
            For j = Pix0 To PixN
                If j < Yline.Length Then
                    If Yline(j) >= MaxPix Then
                        SaturationLabel.Text = "Saturated"
                        SaturationLabel.BackColor = Color.LightCoral
                    End If
                    Ypix(i).Points.Add(Yline(j))
                End If
            Next
            'Set the chart configuration and display
            Ypix(i).XValueType = ChartValueType.Auto
            Ypix(i).ChartType = SeriesChartType.SplineArea
            'Ypix(i).MarkerColor = Color.Black
            'Ypix(i).BorderColor = Color.Black
            'Ypix(i).BorderWidth = 1
            'Ypix(i).Color = Color.Black
            Ypix(i).MarkerStyle = MarkerStyle.Circle
        Next
        'All done
        Return
    End Sub

    Private Function GetSeeingClass(FWHM As Double, aperture As Double) As String
        'Seeing calculator based on aperature and FWHM, using Canadian Weather Service table
        '
        'FWHM is adjusted proportionally to a 12" aperture, gauged against the Canadian seeing table values
        '
        Dim apadj As Double = 12 / aperture

        If FWHM < (0.4 * apadj) Then
            Return ("V (Excellent)")
        ElseIf FWHM < (1.0 * apadj) Then
            Return ("IV (Good)")
        ElseIf FWHM < (2.5 * apadj) Then
            Return ("III (Average)")
        ElseIf FWHM < (4.0 * apadj) Then
            Return ("II (Poor)")
        Else
            Return ("I (Bad)")
        End If

    End Function

    Private Function LocateStar(RAStar As Double, DecStar As Double)
        'Find the star on the chart and access it's object information, in particular for apparent magnitude
        Dim actMag As Double

        Dim tsxsc = CreateObject("TheSkyX.sky6StarChart")
        Dim tsxod = CreateObject("TheSkyX.sky6ObjectInformation")
        Dim tsxut = CreateObject("TheSkyX.sky6Utils")

        'Ultimately, we want to center the star chart on the FOV of the image,
        '  but not resize the chart

        tsxut.ConvertStringtoRA(tsximg.FITSKeyWord("OBJCTRA"))
        Dim RACen = tsxut.dOut0()
        tsxut.ConvertStringtoDec(tsximg.FITSKeyWord("OBJCTDEC"))
        Dim DecCen = tsxut.dOut0()

        'Center the star chart on the RA/Dec coordinates
        tsxsc.RightAscension = RAStar
        tsxsc.Declination = DecStar
        Dim Xcen = tsxsc.WidthinPixels / 2
        Dim Ycen = tsxsc.HeightinPixels / 2

        tsxsc.ClickFind(Xcen, Ycen)

        tsxod.Property(TheSkyXLib.Sk6ObjectInformationProperty.sk6ObjInfoProp_MAG)
        actMag = tsxod.ObjInfoPropOut()

        'Now recenter the star chart on the center of the image
        tsxsc.RightAscension = RACen
        tsxsc.Declination = DecCen
        Return (actMag)

    End Function

End Class
