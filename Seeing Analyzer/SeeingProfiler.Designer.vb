<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeeingProfiler
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeeingProfiler))
        Me.MagChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SaturationLabel = New System.Windows.Forms.Label()
        Me.AnalysisToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.FWHMLabel = New System.Windows.Forms.Label()
        Me.MagZeroPtLabel = New System.Windows.Forms.Label()
        Me.RALabel = New System.Windows.Forms.Label()
        Me.DecLabel = New System.Windows.Forms.Label()
        Me.EllipseLabel = New System.Windows.Forms.Label()
        Me.AiryDiskLabel = New System.Windows.Forms.Label()
        Me.SeeingLabel = New System.Windows.Forms.Label()
        Me.SeeingClassLabel = New System.Windows.Forms.Label()
        Me.ResolutionLabel = New System.Windows.Forms.Label()
        Me.AnalyzeButton = New System.Windows.Forms.Button()
        Me.ReadMeButton = New System.Windows.Forms.Button()
        Me.ActMagLabel = New System.Windows.Forms.Label()
        Me.XLabel = New System.Windows.Forms.Label()
        Me.YLabel = New System.Windows.Forms.Label()
        CType(Me.MagChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MagChart
        '
        Me.MagChart.BorderlineWidth = 0
        ChartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.IsRightAngleAxes = False
        ChartArea1.Area3DStyle.Perspective = 10
        ChartArea1.Area3DStyle.WallWidth = 0
        ChartArea1.BorderWidth = 0
        ChartArea1.Name = "ChartArea1"
        Me.MagChart.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.MagChart.Legends.Add(Legend1)
        Me.MagChart.Location = New System.Drawing.Point(12, 63)
        Me.MagChart.Name = "MagChart"
        Me.MagChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.MagChart.Series.Add(Series1)
        Me.MagChart.Size = New System.Drawing.Size(500, 360)
        Me.MagChart.TabIndex = 1
        Me.MagChart.Text = "Magnitude"
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(328, 506)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 2
        Me.NextButton.Text = "Next"
        Me.AnalysisToolTips.SetToolTip(Me.NextButton, "Move to next star image selection in order of magnitude.")
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(247, 506)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 3
        Me.BackButton.Text = "Back"
        Me.AnalysisToolTips.SetToolTip(Me.BackButton, "Move to previously selected star image.")
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(437, 506)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 5
        Me.CloseButton.Text = "Done"
        Me.AnalysisToolTips.SetToolTip(Me.CloseButton, "Close application")
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SaturationLabel
        '
        Me.SaturationLabel.AutoSize = True
        Me.SaturationLabel.Location = New System.Drawing.Point(12, 475)
        Me.SaturationLabel.Name = "SaturationLabel"
        Me.SaturationLabel.Size = New System.Drawing.Size(20, 13)
        Me.SaturationLabel.TabIndex = 7
        Me.SaturationLabel.Text = "SL"
        '
        'AnalysisToolTips
        '
        Me.AnalysisToolTips.AutoPopDelay = 30000
        Me.AnalysisToolTips.InitialDelay = 1000
        Me.AnalysisToolTips.ReshowDelay = 100
        '
        'FWHMLabel
        '
        Me.FWHMLabel.AutoSize = True
        Me.FWHMLabel.Location = New System.Drawing.Point(194, 442)
        Me.FWHMLabel.Name = "FWHMLabel"
        Me.FWHMLabel.Size = New System.Drawing.Size(68, 13)
        Me.FWHMLabel.TabIndex = 8
        Me.FWHMLabel.Text = "FWHM =      "
        Me.AnalysisToolTips.SetToolTip(Me.FWHMLabel, "Full Width Half Maximum of selected star image")
        '
        'MagZeroPtLabel
        '
        Me.MagZeroPtLabel.AutoSize = True
        Me.MagZeroPtLabel.Location = New System.Drawing.Point(35, 442)
        Me.MagZeroPtLabel.Name = "MagZeroPtLabel"
        Me.MagZeroPtLabel.Size = New System.Drawing.Size(127, 13)
        Me.MagZeroPtLabel.TabIndex = 9
        Me.MagZeroPtLabel.Text = "Mag Zero Pt Offset =       "
        Me.AnalysisToolTips.SetToolTip(Me.MagZeroPtLabel, "Magnitude of selected star image (bits)")
        '
        'RALabel
        '
        Me.RALabel.AutoSize = True
        Me.RALabel.Location = New System.Drawing.Point(288, 475)
        Me.RALabel.Name = "RALabel"
        Me.RALabel.Size = New System.Drawing.Size(40, 13)
        Me.RALabel.TabIndex = 10
        Me.RALabel.Text = "RA =   "
        Me.AnalysisToolTips.SetToolTip(Me.RALabel, "X position of selected star image")
        '
        'DecLabel
        '
        Me.DecLabel.AutoSize = True
        Me.DecLabel.Location = New System.Drawing.Point(431, 475)
        Me.DecLabel.Name = "DecLabel"
        Me.DecLabel.Size = New System.Drawing.Size(45, 13)
        Me.DecLabel.TabIndex = 11
        Me.DecLabel.Text = "Dec =   "
        Me.AnalysisToolTips.SetToolTip(Me.DecLabel, "Y position of selected star image")
        '
        'EllipseLabel
        '
        Me.EllipseLabel.AutoSize = True
        Me.EllipseLabel.Location = New System.Drawing.Point(288, 442)
        Me.EllipseLabel.Name = "EllipseLabel"
        Me.EllipseLabel.Size = New System.Drawing.Size(59, 13)
        Me.EllipseLabel.TabIndex = 12
        Me.EllipseLabel.Text = "Ellpse =     "
        Me.AnalysisToolTips.SetToolTip(Me.EllipseLabel, "Ellipsicity of selected star image")
        '
        'AiryDiskLabel
        '
        Me.AiryDiskLabel.AutoSize = True
        Me.AiryDiskLabel.Location = New System.Drawing.Point(183, 24)
        Me.AiryDiskLabel.Name = "AiryDiskLabel"
        Me.AiryDiskLabel.Size = New System.Drawing.Size(78, 13)
        Me.AiryDiskLabel.TabIndex = 13
        Me.AiryDiskLabel.Text = "Airy Disk =       "
        Me.AnalysisToolTips.SetToolTip(Me.AiryDiskLabel, "2.76 / Aperture (inches)")
        '
        'SeeingLabel
        '
        Me.SeeingLabel.AutoSize = True
        Me.SeeingLabel.Location = New System.Drawing.Point(267, 24)
        Me.SeeingLabel.Name = "SeeingLabel"
        Me.SeeingLabel.Size = New System.Drawing.Size(70, 13)
        Me.SeeingLabel.TabIndex = 14
        Me.SeeingLabel.Text = "Seeing =       "
        Me.AnalysisToolTips.SetToolTip(Me.SeeingLabel, "Average FWHM (arcsec) of imaged stars")
        '
        'SeeingClassLabel
        '
        Me.SeeingClassLabel.AutoSize = True
        Me.SeeingClassLabel.Location = New System.Drawing.Point(355, 24)
        Me.SeeingClassLabel.Name = "SeeingClassLabel"
        Me.SeeingClassLabel.Size = New System.Drawing.Size(98, 13)
        Me.SeeingClassLabel.TabIndex = 15
        Me.SeeingClassLabel.Text = "Seeing Class =       "
        Me.AnalysisToolTips.SetToolTip(Me.SeeingClassLabel, resources.GetString("SeeingClassLabel.ToolTip"))
        '
        'ResolutionLabel
        '
        Me.ResolutionLabel.AutoSize = True
        Me.ResolutionLabel.Location = New System.Drawing.Point(9, 24)
        Me.ResolutionLabel.Name = "ResolutionLabel"
        Me.ResolutionLabel.Size = New System.Drawing.Size(107, 13)
        Me.ResolutionLabel.TabIndex = 16
        Me.ResolutionLabel.Text = "Resolution (arcsec) ="
        Me.AnalysisToolTips.SetToolTip(Me.ResolutionLabel, "Pixel Size (microns) * 206.256 / Focal Length (inches)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'AnalyzeButton
        '
        Me.AnalyzeButton.Location = New System.Drawing.Point(137, 506)
        Me.AnalyzeButton.Name = "AnalyzeButton"
        Me.AnalyzeButton.Size = New System.Drawing.Size(75, 23)
        Me.AnalyzeButton.TabIndex = 0
        Me.AnalyzeButton.Text = "Analyze"
        Me.AnalysisToolTips.SetToolTip(Me.AnalyzeButton, "Run Image LInk on currently active TSX image, then" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "compute seeing characteristic" & _
        "s and display magnitude" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "graph of starting with star with greatest magnitude.")
        Me.AnalyzeButton.UseVisualStyleBackColor = True
        '
        'ReadMeButton
        '
        Me.ReadMeButton.Location = New System.Drawing.Point(15, 506)
        Me.ReadMeButton.Name = "ReadMeButton"
        Me.ReadMeButton.Size = New System.Drawing.Size(75, 23)
        Me.ReadMeButton.TabIndex = 17
        Me.ReadMeButton.Text = "Read Me"
        Me.AnalysisToolTips.SetToolTip(Me.ReadMeButton, "Run Image LInk on currently active TSX image, then" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "compute seeing characteristic" & _
        "s and display magnitude" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "graph of starting with star with greatest magnitude.")
        Me.ReadMeButton.UseVisualStyleBackColor = True
        '
        'ActMagLabel
        '
        Me.ActMagLabel.AutoSize = True
        Me.ActMagLabel.Location = New System.Drawing.Point(71, 475)
        Me.ActMagLabel.Name = "ActMagLabel"
        Me.ActMagLabel.Size = New System.Drawing.Size(91, 13)
        Me.ActMagLabel.TabIndex = 18
        Me.ActMagLabel.Text = "Actual Mag =       "
        Me.AnalysisToolTips.SetToolTip(Me.ActMagLabel, "How far off the TSX Magnitude Zero Point setting is" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from the value it should hav" & _
        "e such that the calculated" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "magnitude value is the same as the cateloged value.")
        '
        'XLabel
        '
        Me.XLabel.AutoSize = True
        Me.XLabel.Location = New System.Drawing.Point(373, 442)
        Me.XLabel.Name = "XLabel"
        Me.XLabel.Size = New System.Drawing.Size(32, 13)
        Me.XLabel.TabIndex = 19
        Me.XLabel.Text = "X =   "
        Me.AnalysisToolTips.SetToolTip(Me.XLabel, "X position of selected star image")
        '
        'YLabel
        '
        Me.YLabel.AutoSize = True
        Me.YLabel.Location = New System.Drawing.Point(431, 442)
        Me.YLabel.Name = "YLabel"
        Me.YLabel.Size = New System.Drawing.Size(32, 13)
        Me.YLabel.TabIndex = 20
        Me.YLabel.Text = "Y =   "
        Me.AnalysisToolTips.SetToolTip(Me.YLabel, "Y position of selected star image")
        '
        'SeeingProfiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 540)
        Me.Controls.Add(Me.YLabel)
        Me.Controls.Add(Me.XLabel)
        Me.Controls.Add(Me.ActMagLabel)
        Me.Controls.Add(Me.ReadMeButton)
        Me.Controls.Add(Me.ResolutionLabel)
        Me.Controls.Add(Me.SeeingClassLabel)
        Me.Controls.Add(Me.SeeingLabel)
        Me.Controls.Add(Me.AiryDiskLabel)
        Me.Controls.Add(Me.EllipseLabel)
        Me.Controls.Add(Me.DecLabel)
        Me.Controls.Add(Me.RALabel)
        Me.Controls.Add(Me.MagZeroPtLabel)
        Me.Controls.Add(Me.FWHMLabel)
        Me.Controls.Add(Me.SaturationLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.AnalyzeButton)
        Me.Controls.Add(Me.MagChart)
        Me.Name = "SeeingProfiler"
        Me.Text = "Seeing Analyzer V1.2"
        CType(Me.MagChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MagChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents SaturationLabel As System.Windows.Forms.Label
    Friend WithEvents AnalysisToolTips As System.Windows.Forms.ToolTip
    Friend WithEvents FWHMLabel As System.Windows.Forms.Label
    Friend WithEvents MagZeroPtLabel As System.Windows.Forms.Label
    Friend WithEvents RALabel As System.Windows.Forms.Label
    Friend WithEvents DecLabel As System.Windows.Forms.Label
    Friend WithEvents EllipseLabel As System.Windows.Forms.Label
    Private WithEvents AiryDiskLabel As System.Windows.Forms.Label
    Private WithEvents SeeingLabel As System.Windows.Forms.Label
    Private WithEvents SeeingClassLabel As System.Windows.Forms.Label
    Private WithEvents ResolutionLabel As System.Windows.Forms.Label
    Friend WithEvents AnalyzeButton As System.Windows.Forms.Button
    Friend WithEvents ReadMeButton As System.Windows.Forms.Button
    Friend WithEvents ActMagLabel As System.Windows.Forms.Label
    Friend WithEvents XLabel As System.Windows.Forms.Label
    Friend WithEvents YLabel As System.Windows.Forms.Label

End Class
