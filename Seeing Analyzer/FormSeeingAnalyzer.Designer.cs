using System.Drawing;

namespace Seeing_Analyzer
{
    partial class FormSeeingAnalyzer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeeingAnalyzer));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MaxADULabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.CatMagLabel = new System.Windows.Forms.Label();
            this.SeeingClassLabel = new System.Windows.Forms.Label();
            this.SeeingLabel = new System.Windows.Forms.Label();
            this.AiryDiskLabel = new System.Windows.Forms.Label();
            this.Ellipticity = new System.Windows.Forms.Label();
            this.RALabel = new System.Windows.Forms.Label();
            this.MagZeroPtLabel = new System.Windows.Forms.Label();
            this.FWHMLabel = new System.Windows.Forms.Label();
            this.AnalysisToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.DecLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.InstMag = new System.Windows.Forms.Label();
            this.BackgroundLabel = new System.Windows.Forms.Label();
            this.AvgMagZeroOffsetLabel = new System.Windows.Forms.Label();
            this.StarCountLabel = new System.Windows.Forms.Label();
            this.MeanMInInstMagLabel = new System.Windows.Forms.Label();
            this.MeanMinCatMagLabel = new System.Windows.Forms.Label();
            this.ExposureLabel = new System.Windows.Forms.Label();
            this.CoreMagRatioLabel = new System.Windows.Forms.Label();
            this.MeanEllipsicityLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AttachButton = new System.Windows.Forms.Button();
            this.OpenFitsButton = new System.Windows.Forms.Button();
            this.ReadMeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.StarADUChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MeanFWHMBox = new System.Windows.Forms.TextBox();
            this.MeanEllipticityBox = new System.Windows.Forms.TextBox();
            this.SeeingClassBox = new System.Windows.Forms.TextBox();
            this.PerfectPixelMicronBox = new System.Windows.Forms.TextBox();
            this.AiryDiskarcsecBox = new System.Windows.Forms.TextBox();
            this.PhotometryGroupBox = new System.Windows.Forms.GroupBox();
            this.StarYBox = new System.Windows.Forms.TextBox();
            this.StarDecBox = new System.Windows.Forms.TextBox();
            this.StarXBox = new System.Windows.Forms.TextBox();
            this.StarRABox = new System.Windows.Forms.TextBox();
            this.StarCatMagDeltaBox = new System.Windows.Forms.TextBox();
            this.StarEllipticityBox = new System.Windows.Forms.TextBox();
            this.StarPeakADUBox = new System.Windows.Forms.TextBox();
            this.StarFWHMBox = new System.Windows.Forms.TextBox();
            this.StarCatMagBox = new System.Windows.Forms.TextBox();
            this.StarInstMagBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TargetBox = new System.Windows.Forms.TextBox();
            this.FileTimeBox = new System.Windows.Forms.TextBox();
            this.FileDateBox = new System.Windows.Forms.TextBox();
            this.BackgroundADUBox = new System.Windows.Forms.TextBox();
            this.ExposureBox = new System.Windows.Forms.TextBox();
            this.StarCountBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.InstLimitingMagBox = new System.Windows.Forms.TextBox();
            this.CatLimitingMagBox = new System.Windows.Forms.TextBox();
            this.MeanCatInstMagDeltaBox = new System.Windows.Forms.TextBox();
            this.MeanCatInstMagRatioBox = new System.Windows.Forms.TextBox();
            this.PhotometryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OpenFitsDialog = new System.Windows.Forms.OpenFileDialog();
            this.SubframeGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AntseyTotalFramesLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SLambdaLabel = new System.Windows.Forms.Label();
            this.TotalFrames = new System.Windows.Forms.NumericUpDown();
            this.SessionHoursBox = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.MinFaintADU = new System.Windows.Forms.NumericUpDown();
            this.AnExpTotalTimeLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.SNRPercentBox = new System.Windows.Forms.NumericUpDown();
            this.Label5 = new System.Windows.Forms.Label();
            this.CaExpLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.MaxReadNoiseBox = new System.Windows.Forms.NumericUpDown();
            this.SmExpLabel = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ReadNoiseBox = new System.Windows.Forms.NumericUpDown();
            this.GainLabel = new System.Windows.Forms.Label();
            this.GainBox = new System.Windows.Forms.NumericUpDown();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.InstrumentationGroupBox = new System.Windows.Forms.GroupBox();
            this.AiryDiskmicronBox = new System.Windows.Forms.TextBox();
            this.PerfectPixelArcSecBox = new System.Windows.Forms.TextBox();
            this.MaxResolutionArcSecBox = new System.Windows.Forms.TextBox();
            this.PixSizeArcSecBox = new System.Windows.Forms.TextBox();
            this.PixSizeMicronBox = new System.Windows.Forms.TextBox();
            this.FocalRatioBox = new System.Windows.Forms.TextBox();
            this.ApertureBox = new System.Windows.Forms.TextBox();
            this.FocalLengthBox = new System.Windows.Forms.TextBox();
            this.VariationGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PhotoStarBox = new System.Windows.Forms.TextBox();
            this.PhotoFilterBox = new System.Windows.Forms.TextBox();
            this.OpenFileNameBox = new System.Windows.Forms.TextBox();
            this.OverviewButton = new System.Windows.Forms.Button();
            this.OnTopCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.StarADUChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PhotometryGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotometryChart)).BeginInit();
            this.SubframeGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionHoursBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinFaintADU)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SNRPercentBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxReadNoiseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadNoiseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GainBox)).BeginInit();
            this.InstrumentationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariationGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // MaxADULabel
            // 
            this.MaxADULabel.AutoSize = true;
            this.MaxADULabel.Location = new System.Drawing.Point(21, 97);
            this.MaxADULabel.Name = "MaxADULabel";
            this.MaxADULabel.Size = new System.Drawing.Size(58, 13);
            this.MaxADULabel.TabIndex = 40;
            this.MaxADULabel.Text = "Peak ADU";
            this.AnalysisToolTips.SetToolTip(this.MaxADULabel, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(116, 197);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(14, 13);
            this.YLabel.TabIndex = 39;
            this.YLabel.Text = "Y";
            this.AnalysisToolTips.SetToolTip(this.YLabel, "Y position of selected star image");
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(116, 172);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(14, 13);
            this.XLabel.TabIndex = 38;
            this.XLabel.Text = "X";
            this.AnalysisToolTips.SetToolTip(this.XLabel, "X position of selected star image");
            // 
            // CatMagLabel
            // 
            this.CatMagLabel.AutoSize = true;
            this.CatMagLabel.Location = new System.Drawing.Point(21, 47);
            this.CatMagLabel.Name = "CatMagLabel";
            this.CatMagLabel.Size = new System.Drawing.Size(67, 13);
            this.CatMagLabel.TabIndex = 37;
            this.CatMagLabel.Text = "Catalog Mag";
            this.AnalysisToolTips.SetToolTip(this.CatMagLabel, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // SeeingClassLabel
            // 
            this.SeeingClassLabel.AutoSize = true;
            this.SeeingClassLabel.Location = new System.Drawing.Point(11, 47);
            this.SeeingClassLabel.Name = "SeeingClassLabel";
            this.SeeingClassLabel.Size = new System.Drawing.Size(68, 13);
            this.SeeingClassLabel.TabIndex = 34;
            this.SeeingClassLabel.Text = "Seeing Class";
            this.AnalysisToolTips.SetToolTip(this.SeeingClassLabel, resources.GetString("SeeingClassLabel.ToolTip"));
            // 
            // SeeingLabel
            // 
            this.SeeingLabel.AutoSize = true;
            this.SeeingLabel.Location = new System.Drawing.Point(11, 20);
            this.SeeingLabel.Name = "SeeingLabel";
            this.SeeingLabel.Size = new System.Drawing.Size(115, 13);
            this.SeeingLabel.TabIndex = 33;
            this.SeeingLabel.Text = "Mean FWHM (arcsec) ";
            this.AnalysisToolTips.SetToolTip(this.SeeingLabel, "Average FWHM (arcsec) of imaged stars");
            // 
            // AiryDiskLabel
            // 
            this.AiryDiskLabel.AutoSize = true;
            this.AiryDiskLabel.Location = new System.Drawing.Point(532, 49);
            this.AiryDiskLabel.Name = "AiryDiskLabel";
            this.AiryDiskLabel.Size = new System.Drawing.Size(101, 13);
            this.AiryDiskLabel.TabIndex = 32;
            this.AiryDiskLabel.Text = "Airy Disk (arcsec)    ";
            this.AnalysisToolTips.SetToolTip(this.AiryDiskLabel, "2.76 / Aperture (inches)");
            // 
            // Ellipticity
            // 
            this.Ellipticity.AutoSize = true;
            this.Ellipticity.Location = new System.Drawing.Point(21, 122);
            this.Ellipticity.Name = "Ellipticity";
            this.Ellipticity.Size = new System.Drawing.Size(47, 13);
            this.Ellipticity.TabIndex = 31;
            this.Ellipticity.Text = "Ellipticity";
            this.AnalysisToolTips.SetToolTip(this.Ellipticity, "Ellipsicity of selected star image");
            // 
            // RALabel
            // 
            this.RALabel.AutoSize = true;
            this.RALabel.Location = new System.Drawing.Point(21, 172);
            this.RALabel.Name = "RALabel";
            this.RALabel.Size = new System.Drawing.Size(22, 13);
            this.RALabel.TabIndex = 29;
            this.RALabel.Text = "RA";
            this.AnalysisToolTips.SetToolTip(this.RALabel, "X position of selected star image");
            // 
            // MagZeroPtLabel
            // 
            this.MagZeroPtLabel.AutoSize = true;
            this.MagZeroPtLabel.Location = new System.Drawing.Point(21, 147);
            this.MagZeroPtLabel.Name = "MagZeroPtLabel";
            this.MagZeroPtLabel.Size = new System.Drawing.Size(99, 13);
            this.MagZeroPtLabel.TabIndex = 28;
            this.MagZeroPtLabel.Text = "Cat Mag Difference";
            this.AnalysisToolTips.SetToolTip(this.MagZeroPtLabel, "Magnitude of selected star image (bits)");
            // 
            // FWHMLabel
            // 
            this.FWHMLabel.AutoSize = true;
            this.FWHMLabel.Location = new System.Drawing.Point(21, 72);
            this.FWHMLabel.Name = "FWHMLabel";
            this.FWHMLabel.Size = new System.Drawing.Size(82, 13);
            this.FWHMLabel.TabIndex = 27;
            this.FWHMLabel.Text = "FWHM (arcsec)";
            this.AnalysisToolTips.SetToolTip(this.FWHMLabel, "Full Width Half Maximum of selected star image");
            // 
            // AnalysisToolTips
            // 
            this.AnalysisToolTips.AutoPopDelay = 30000;
            this.AnalysisToolTips.InitialDelay = 1000;
            this.AnalysisToolTips.ReshowDelay = 100;
            // 
            // DecLabel
            // 
            this.DecLabel.AutoSize = true;
            this.DecLabel.Location = new System.Drawing.Point(21, 197);
            this.DecLabel.Name = "DecLabel";
            this.DecLabel.Size = new System.Drawing.Size(27, 13);
            this.DecLabel.TabIndex = 30;
            this.DecLabel.Text = "Dec";
            this.AnalysisToolTips.SetToolTip(this.DecLabel, "Y position of selected star image");
            // 
            // BackButton
            // 
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(20, 231);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(48, 23);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "<<";
            this.AnalysisToolTips.SetToolTip(this.BackButton, "Move to previously selected star image.");
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.ForeColor = System.Drawing.Color.Black;
            this.NextButton.Location = new System.Drawing.Point(128, 231);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(48, 23);
            this.NextButton.TabIndex = 23;
            this.NextButton.Text = ">>";
            this.AnalysisToolTips.SetToolTip(this.NextButton, "Move to next star image selection in order of magnitude.");
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // InstMag
            // 
            this.InstMag.AutoSize = true;
            this.InstMag.Location = new System.Drawing.Point(21, 22);
            this.InstMag.Name = "InstMag";
            this.InstMag.Size = new System.Drawing.Size(48, 13);
            this.InstMag.TabIndex = 43;
            this.InstMag.Text = "Inst Mag";
            this.AnalysisToolTips.SetToolTip(this.InstMag, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.AutoSize = true;
            this.BackgroundLabel.Location = new System.Drawing.Point(8, 185);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(112, 13);
            this.BackgroundLabel.TabIndex = 52;
            this.BackgroundLabel.Text = "Background (ADU)     ";
            this.AnalysisToolTips.SetToolTip(this.BackgroundLabel, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // AvgMagZeroOffsetLabel
            // 
            this.AvgMagZeroOffsetLabel.AutoSize = true;
            this.AvgMagZeroOffsetLabel.Location = new System.Drawing.Point(19, 122);
            this.AvgMagZeroOffsetLabel.Name = "AvgMagZeroOffsetLabel";
            this.AvgMagZeroOffsetLabel.Size = new System.Drawing.Size(81, 13);
            this.AvgMagZeroOffsetLabel.TabIndex = 53;
            this.AvgMagZeroOffsetLabel.Text = "Catalog - Image";
            this.AnalysisToolTips.SetToolTip(this.AvgMagZeroOffsetLabel, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // StarCountLabel
            // 
            this.StarCountLabel.AutoSize = true;
            this.StarCountLabel.Location = new System.Drawing.Point(8, 145);
            this.StarCountLabel.Name = "StarCountLabel";
            this.StarCountLabel.Size = new System.Drawing.Size(57, 13);
            this.StarCountLabel.TabIndex = 54;
            this.StarCountLabel.Text = "Star Count";
            this.AnalysisToolTips.SetToolTip(this.StarCountLabel, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // MeanMInInstMagLabel
            // 
            this.MeanMInInstMagLabel.AutoSize = true;
            this.MeanMInInstMagLabel.Location = new System.Drawing.Point(19, 38);
            this.MeanMInInstMagLabel.Name = "MeanMInInstMagLabel";
            this.MeanMInInstMagLabel.Size = new System.Drawing.Size(73, 13);
            this.MeanMInInstMagLabel.TabIndex = 55;
            this.MeanMInInstMagLabel.Text = "Lowest Image";
            this.AnalysisToolTips.SetToolTip(this.MeanMInInstMagLabel, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // MeanMinCatMagLabel
            // 
            this.MeanMinCatMagLabel.AutoSize = true;
            this.MeanMinCatMagLabel.Location = new System.Drawing.Point(20, 62);
            this.MeanMinCatMagLabel.Name = "MeanMinCatMagLabel";
            this.MeanMinCatMagLabel.Size = new System.Drawing.Size(80, 13);
            this.MeanMinCatMagLabel.TabIndex = 56;
            this.MeanMinCatMagLabel.Text = "Lowest Catalog";
            this.AnalysisToolTips.SetToolTip(this.MeanMinCatMagLabel, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // ExposureLabel
            // 
            this.ExposureLabel.AutoSize = true;
            this.ExposureLabel.Location = new System.Drawing.Point(6, 119);
            this.ExposureLabel.Name = "ExposureLabel";
            this.ExposureLabel.Size = new System.Drawing.Size(77, 13);
            this.ExposureLabel.TabIndex = 57;
            this.ExposureLabel.Text = "Exposure (sec)";
            this.AnalysisToolTips.SetToolTip(this.ExposureLabel, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // CoreMagRatioLabel
            // 
            this.CoreMagRatioLabel.AutoSize = true;
            this.CoreMagRatioLabel.Location = new System.Drawing.Point(19, 147);
            this.CoreMagRatioLabel.Name = "CoreMagRatioLabel";
            this.CoreMagRatioLabel.Size = new System.Drawing.Size(77, 13);
            this.CoreMagRatioLabel.TabIndex = 58;
            this.CoreMagRatioLabel.Text = "Catalog/Image";
            this.AnalysisToolTips.SetToolTip(this.CoreMagRatioLabel, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // MeanEllipsicityLabel
            // 
            this.MeanEllipsicityLabel.AutoSize = true;
            this.MeanEllipsicityLabel.Location = new System.Drawing.Point(11, 72);
            this.MeanEllipsicityLabel.Name = "MeanEllipsicityLabel";
            this.MeanEllipsicityLabel.Size = new System.Drawing.Size(77, 13);
            this.MeanEllipsicityLabel.TabIndex = 59;
            this.MeanEllipsicityLabel.Text = "Mean Ellipticity";
            this.AnalysisToolTips.SetToolTip(this.MeanEllipsicityLabel, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Focal Length (mm)";
            this.AnalysisToolTips.SetToolTip(this.label3, "2.76 / Aperture (inches)");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Aperture (mm)";
            this.AnalysisToolTips.SetToolTip(this.label10, "2.76 / Aperture (inches)");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Focal Ratio";
            this.AnalysisToolTips.SetToolTip(this.label11, "2.76 / Aperture (inches)");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(359, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "Pixel Size (micron)";
            this.AnalysisToolTips.SetToolTip(this.label12, "2.76 / Aperture (inches)");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(692, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "Perfect Pixel (micron)";
            this.AnalysisToolTips.SetToolTip(this.label13, "2.76 / Aperture (inches)");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(359, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "Pixel Scale (arcsec)";
            this.AnalysisToolTips.SetToolTip(this.label14, "2.76 / Aperture (inches)");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(178, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 70;
            this.label15.Text = "Inst Precision (arcsec)";
            this.AnalysisToolTips.SetToolTip(this.label15, "2.76 / Aperture (inches)");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(692, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 13);
            this.label16.TabIndex = 77;
            this.label16.Text = "Perfect Pixel (arcsec)";
            this.AnalysisToolTips.SetToolTip(this.label16, "2.76 / Aperture (inches)");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(532, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 13);
            this.label18.TabIndex = 80;
            this.label18.Text = "Airy Disk (micron)    ";
            this.AnalysisToolTips.SetToolTip(this.label18, "2.76 / Aperture (inches)");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 82;
            this.label17.Text = "Date";
            this.AnalysisToolTips.SetToolTip(this.label17, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 84;
            this.label19.Text = "Time";
            this.AnalysisToolTips.SetToolTip(this.label19, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 86;
            this.label20.Text = "Target";
            this.AnalysisToolTips.SetToolTip(this.label20, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(85, 236);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 13);
            this.label21.TabIndex = 92;
            this.label21.Text = "Star";
            this.AnalysisToolTips.SetToolTip(this.label21, "Ellipsicity of selected star image");
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(730, 430);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 13);
            this.label22.TabIndex = 88;
            this.label22.Text = "Star";
            this.AnalysisToolTips.SetToolTip(this.label22, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(944, 430);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 13);
            this.label23.TabIndex = 90;
            this.label23.Text = "Filter";
            this.AnalysisToolTips.SetToolTip(this.label23, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Averages";
            this.AnalysisToolTips.SetToolTip(this.label6, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Magnitude Limits";
            this.AnalysisToolTips.SetToolTip(this.label8, "How far off the TSX Magnitude Zero Point setting is\r\nfrom the value it should hav" +
        "e such that the calculated\r\nmagnitude value is the same as the cateloged value.");
            // 
            // AttachButton
            // 
            this.AttachButton.ForeColor = System.Drawing.Color.Black;
            this.AttachButton.Location = new System.Drawing.Point(191, 16);
            this.AttachButton.Name = "AttachButton";
            this.AttachButton.Size = new System.Drawing.Size(93, 23);
            this.AttachButton.TabIndex = 96;
            this.AttachButton.Text = "Attach from TSX";
            this.AnalysisToolTips.SetToolTip(this.AttachButton, "Run Image LInk on currently active TSX image, then\r\ncompute seeing characteristic" +
        "s and display magnitude\r\ngraph of starting with star with greatest magnitude.");
            this.AttachButton.UseVisualStyleBackColor = true;
            this.AttachButton.Click += new System.EventHandler(this.AttachButton_Click);
            // 
            // OpenFitsButton
            // 
            this.OpenFitsButton.ForeColor = System.Drawing.Color.Black;
            this.OpenFitsButton.Location = new System.Drawing.Point(307, 16);
            this.OpenFitsButton.Name = "OpenFitsButton";
            this.OpenFitsButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFitsButton.TabIndex = 95;
            this.OpenFitsButton.Text = "Open";
            this.AnalysisToolTips.SetToolTip(this.OpenFitsButton, "Run Image LInk on currently active TSX image, then\r\ncompute seeing characteristic" +
        "s and display magnitude\r\ngraph of starting with star with greatest magnitude.");
            this.OpenFitsButton.UseVisualStyleBackColor = true;
            this.OpenFitsButton.Click += new System.EventHandler(this.OpenFitsButton_Click);
            // 
            // ReadMeButton
            // 
            this.ReadMeButton.ForeColor = System.Drawing.Color.Black;
            this.ReadMeButton.Location = new System.Drawing.Point(10, 16);
            this.ReadMeButton.Name = "ReadMeButton";
            this.ReadMeButton.Size = new System.Drawing.Size(75, 23);
            this.ReadMeButton.TabIndex = 94;
            this.ReadMeButton.Text = "Help";
            this.AnalysisToolTips.SetToolTip(this.ReadMeButton, "Run Image LInk on currently active TSX image, then\r\ncompute seeing characteristic" +
        "s and display magnitude\r\ngraph of starting with star with greatest magnitude.");
            this.ReadMeButton.UseVisualStyleBackColor = true;
            this.ReadMeButton.Click += new System.EventHandler(this.ReadMeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(962, 16);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 93;
            this.CloseButton.Text = "Done";
            this.AnalysisToolTips.SetToolTip(this.CloseButton, "Close application");
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // StarADUChart
            // 
            this.StarADUChart.BackColor = System.Drawing.Color.LightCyan;
            this.StarADUChart.BorderlineWidth = 0;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.Title = "ArcSec";
            chartArea1.AxisY.Title = "ADU";
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.StarADUChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.StarADUChart.Legends.Add(legend1);
            this.StarADUChart.Location = new System.Drawing.Point(198, 147);
            this.StarADUChart.Name = "StarADUChart";
            this.StarADUChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.StarADUChart.Series.Add(series1);
            this.StarADUChart.Size = new System.Drawing.Size(314, 262);
            this.StarADUChart.TabIndex = 41;
            this.StarADUChart.Text = "Magnitude";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.BorderColor = System.Drawing.Color.Black;
            title1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "StarGraphTitle";
            title1.Text = "Star Name";
            this.StarADUChart.Titles.Add(title1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MeanFWHMBox);
            this.groupBox1.Controls.Add(this.MeanEllipticityBox);
            this.groupBox1.Controls.Add(this.SeeingClassBox);
            this.groupBox1.Controls.Add(this.MeanEllipsicityLabel);
            this.groupBox1.Controls.Add(this.SeeingClassLabel);
            this.groupBox1.Controls.Add(this.SeeingLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 269);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seeing Characteristics";
            // 
            // MeanFWHMBox
            // 
            this.MeanFWHMBox.Location = new System.Drawing.Point(130, 19);
            this.MeanFWHMBox.Name = "MeanFWHMBox";
            this.MeanFWHMBox.Size = new System.Drawing.Size(40, 20);
            this.MeanFWHMBox.TabIndex = 74;
            this.MeanFWHMBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MeanEllipticityBox
            // 
            this.MeanEllipticityBox.Location = new System.Drawing.Point(130, 69);
            this.MeanEllipticityBox.Name = "MeanEllipticityBox";
            this.MeanEllipticityBox.Size = new System.Drawing.Size(40, 20);
            this.MeanEllipticityBox.TabIndex = 73;
            this.MeanEllipticityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SeeingClassBox
            // 
            this.SeeingClassBox.Location = new System.Drawing.Point(85, 44);
            this.SeeingClassBox.Name = "SeeingClassBox";
            this.SeeingClassBox.Size = new System.Drawing.Size(85, 20);
            this.SeeingClassBox.TabIndex = 72;
            this.SeeingClassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PerfectPixelMicronBox
            // 
            this.PerfectPixelMicronBox.Location = new System.Drawing.Point(805, 20);
            this.PerfectPixelMicronBox.Name = "PerfectPixelMicronBox";
            this.PerfectPixelMicronBox.Size = new System.Drawing.Size(40, 20);
            this.PerfectPixelMicronBox.TabIndex = 71;
            this.PerfectPixelMicronBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AiryDiskarcsecBox
            // 
            this.AiryDiskarcsecBox.Location = new System.Drawing.Point(635, 45);
            this.AiryDiskarcsecBox.Name = "AiryDiskarcsecBox";
            this.AiryDiskarcsecBox.Size = new System.Drawing.Size(40, 20);
            this.AiryDiskarcsecBox.TabIndex = 69;
            this.AiryDiskarcsecBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhotometryGroupBox
            // 
            this.PhotometryGroupBox.Controls.Add(this.label21);
            this.PhotometryGroupBox.Controls.Add(this.StarYBox);
            this.PhotometryGroupBox.Controls.Add(this.StarDecBox);
            this.PhotometryGroupBox.Controls.Add(this.StarXBox);
            this.PhotometryGroupBox.Controls.Add(this.StarRABox);
            this.PhotometryGroupBox.Controls.Add(this.StarCatMagDeltaBox);
            this.PhotometryGroupBox.Controls.Add(this.StarEllipticityBox);
            this.PhotometryGroupBox.Controls.Add(this.StarPeakADUBox);
            this.PhotometryGroupBox.Controls.Add(this.StarFWHMBox);
            this.PhotometryGroupBox.Controls.Add(this.StarCatMagBox);
            this.PhotometryGroupBox.Controls.Add(this.StarInstMagBox);
            this.PhotometryGroupBox.Controls.Add(this.BackButton);
            this.PhotometryGroupBox.Controls.Add(this.NextButton);
            this.PhotometryGroupBox.Controls.Add(this.InstMag);
            this.PhotometryGroupBox.Controls.Add(this.MaxADULabel);
            this.PhotometryGroupBox.Controls.Add(this.YLabel);
            this.PhotometryGroupBox.Controls.Add(this.MagZeroPtLabel);
            this.PhotometryGroupBox.Controls.Add(this.XLabel);
            this.PhotometryGroupBox.Controls.Add(this.CatMagLabel);
            this.PhotometryGroupBox.Controls.Add(this.Ellipticity);
            this.PhotometryGroupBox.Controls.Add(this.RALabel);
            this.PhotometryGroupBox.Controls.Add(this.FWHMLabel);
            this.PhotometryGroupBox.Controls.Add(this.DecLabel);
            this.PhotometryGroupBox.Location = new System.Drawing.Point(518, 140);
            this.PhotometryGroupBox.Name = "PhotometryGroupBox";
            this.PhotometryGroupBox.Size = new System.Drawing.Size(191, 269);
            this.PhotometryGroupBox.TabIndex = 47;
            this.PhotometryGroupBox.TabStop = false;
            this.PhotometryGroupBox.Text = "Stellar Photometry";
            // 
            // StarYBox
            // 
            this.StarYBox.Location = new System.Drawing.Point(137, 194);
            this.StarYBox.Name = "StarYBox";
            this.StarYBox.Size = new System.Drawing.Size(40, 20);
            this.StarYBox.TabIndex = 91;
            this.StarYBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StarDecBox
            // 
            this.StarDecBox.Location = new System.Drawing.Point(54, 194);
            this.StarDecBox.Name = "StarDecBox";
            this.StarDecBox.Size = new System.Drawing.Size(40, 20);
            this.StarDecBox.TabIndex = 90;
            this.StarDecBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StarXBox
            // 
            this.StarXBox.Location = new System.Drawing.Point(137, 170);
            this.StarXBox.Name = "StarXBox";
            this.StarXBox.Size = new System.Drawing.Size(40, 20);
            this.StarXBox.TabIndex = 89;
            this.StarXBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StarRABox
            // 
            this.StarRABox.Location = new System.Drawing.Point(54, 169);
            this.StarRABox.Name = "StarRABox";
            this.StarRABox.Size = new System.Drawing.Size(40, 20);
            this.StarRABox.TabIndex = 88;
            this.StarRABox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StarCatMagDeltaBox
            // 
            this.StarCatMagDeltaBox.Location = new System.Drawing.Point(137, 144);
            this.StarCatMagDeltaBox.Name = "StarCatMagDeltaBox";
            this.StarCatMagDeltaBox.Size = new System.Drawing.Size(40, 20);
            this.StarCatMagDeltaBox.TabIndex = 87;
            this.StarCatMagDeltaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StarEllipticityBox
            // 
            this.StarEllipticityBox.Location = new System.Drawing.Point(137, 119);
            this.StarEllipticityBox.Name = "StarEllipticityBox";
            this.StarEllipticityBox.Size = new System.Drawing.Size(40, 20);
            this.StarEllipticityBox.TabIndex = 86;
            this.StarEllipticityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StarPeakADUBox
            // 
            this.StarPeakADUBox.Location = new System.Drawing.Point(137, 94);
            this.StarPeakADUBox.Name = "StarPeakADUBox";
            this.StarPeakADUBox.Size = new System.Drawing.Size(40, 20);
            this.StarPeakADUBox.TabIndex = 85;
            this.StarPeakADUBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StarFWHMBox
            // 
            this.StarFWHMBox.Location = new System.Drawing.Point(137, 70);
            this.StarFWHMBox.Name = "StarFWHMBox";
            this.StarFWHMBox.Size = new System.Drawing.Size(40, 20);
            this.StarFWHMBox.TabIndex = 84;
            this.StarFWHMBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StarCatMagBox
            // 
            this.StarCatMagBox.Location = new System.Drawing.Point(137, 44);
            this.StarCatMagBox.Name = "StarCatMagBox";
            this.StarCatMagBox.Size = new System.Drawing.Size(40, 20);
            this.StarCatMagBox.TabIndex = 83;
            this.StarCatMagBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StarInstMagBox
            // 
            this.StarInstMagBox.Location = new System.Drawing.Point(137, 19);
            this.StarInstMagBox.Name = "StarInstMagBox";
            this.StarInstMagBox.Size = new System.Drawing.Size(40, 20);
            this.StarInstMagBox.TabIndex = 82;
            this.StarInstMagBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.TargetBox);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.FileTimeBox);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.FileDateBox);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.BackgroundADUBox);
            this.groupBox3.Controls.Add(this.ExposureBox);
            this.groupBox3.Controls.Add(this.StarCountBox);
            this.groupBox3.Controls.Add(this.ExposureLabel);
            this.groupBox3.Controls.Add(this.StarCountLabel);
            this.groupBox3.Controls.Add(this.BackgroundLabel);
            this.groupBox3.Location = new System.Drawing.Point(13, 427);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 427);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Population Photometry";
            // 
            // TargetBox
            // 
            this.TargetBox.Location = new System.Drawing.Point(66, 19);
            this.TargetBox.Name = "TargetBox";
            this.TargetBox.Size = new System.Drawing.Size(100, 20);
            this.TargetBox.TabIndex = 87;
            this.TargetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FileTimeBox
            // 
            this.FileTimeBox.Location = new System.Drawing.Point(66, 73);
            this.FileTimeBox.Name = "FileTimeBox";
            this.FileTimeBox.Size = new System.Drawing.Size(100, 20);
            this.FileTimeBox.TabIndex = 85;
            this.FileTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FileDateBox
            // 
            this.FileDateBox.Location = new System.Drawing.Point(66, 46);
            this.FileDateBox.Name = "FileDateBox";
            this.FileDateBox.Size = new System.Drawing.Size(100, 20);
            this.FileDateBox.TabIndex = 83;
            this.FileDateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackgroundADUBox
            // 
            this.BackgroundADUBox.Location = new System.Drawing.Point(126, 182);
            this.BackgroundADUBox.Name = "BackgroundADUBox";
            this.BackgroundADUBox.Size = new System.Drawing.Size(40, 20);
            this.BackgroundADUBox.TabIndex = 80;
            this.BackgroundADUBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExposureBox
            // 
            this.ExposureBox.Location = new System.Drawing.Point(101, 116);
            this.ExposureBox.Name = "ExposureBox";
            this.ExposureBox.Size = new System.Drawing.Size(65, 20);
            this.ExposureBox.TabIndex = 76;
            this.ExposureBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StarCountBox
            // 
            this.StarCountBox.Location = new System.Drawing.Point(101, 142);
            this.StarCountBox.Name = "StarCountBox";
            this.StarCountBox.Size = new System.Drawing.Size(65, 20);
            this.StarCountBox.TabIndex = 75;
            this.StarCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.MeanMInInstMagLabel);
            this.groupBox6.Controls.Add(this.AvgMagZeroOffsetLabel);
            this.groupBox6.Controls.Add(this.MeanMinCatMagLabel);
            this.groupBox6.Controls.Add(this.CoreMagRatioLabel);
            this.groupBox6.Controls.Add(this.InstLimitingMagBox);
            this.groupBox6.Controls.Add(this.CatLimitingMagBox);
            this.groupBox6.Controls.Add(this.MeanCatInstMagDeltaBox);
            this.groupBox6.Controls.Add(this.MeanCatInstMagRatioBox);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(9, 244);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(164, 177);
            this.groupBox6.TabIndex = 89;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Magnitude Statistics";
            // 
            // InstLimitingMagBox
            // 
            this.InstLimitingMagBox.Location = new System.Drawing.Point(117, 35);
            this.InstLimitingMagBox.Name = "InstLimitingMagBox";
            this.InstLimitingMagBox.Size = new System.Drawing.Size(40, 20);
            this.InstLimitingMagBox.TabIndex = 77;
            this.InstLimitingMagBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CatLimitingMagBox
            // 
            this.CatLimitingMagBox.Location = new System.Drawing.Point(117, 59);
            this.CatLimitingMagBox.Name = "CatLimitingMagBox";
            this.CatLimitingMagBox.Size = new System.Drawing.Size(40, 20);
            this.CatLimitingMagBox.TabIndex = 78;
            this.CatLimitingMagBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MeanCatInstMagDeltaBox
            // 
            this.MeanCatInstMagDeltaBox.Location = new System.Drawing.Point(117, 119);
            this.MeanCatInstMagDeltaBox.Name = "MeanCatInstMagDeltaBox";
            this.MeanCatInstMagDeltaBox.Size = new System.Drawing.Size(40, 20);
            this.MeanCatInstMagDeltaBox.TabIndex = 79;
            this.MeanCatInstMagDeltaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MeanCatInstMagRatioBox
            // 
            this.MeanCatInstMagRatioBox.Location = new System.Drawing.Point(117, 144);
            this.MeanCatInstMagRatioBox.Name = "MeanCatInstMagRatioBox";
            this.MeanCatInstMagRatioBox.Size = new System.Drawing.Size(41, 20);
            this.MeanCatInstMagRatioBox.TabIndex = 81;
            this.MeanCatInstMagRatioBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhotometryChart
            // 
            this.PhotometryChart.BackColor = System.Drawing.Color.LightCyan;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.Title = "Catalog Apparent Magnitude";
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IsReversed = true;
            chartArea2.AxisY.Title = "Camera Apparent Magnitude";
            chartArea2.Name = "ChartArea1";
            this.PhotometryChart.ChartAreas.Add(chartArea2);
            this.PhotometryChart.Location = new System.Drawing.Point(198, 427);
            this.PhotometryChart.Name = "PhotometryChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.IsVisibleInLegend = false;
            series2.Name = "Relative Mag";
            series2.YValuesPerPoint = 2;
            this.PhotometryChart.Series.Add(series2);
            this.PhotometryChart.Size = new System.Drawing.Size(511, 427);
            this.PhotometryChart.TabIndex = 49;
            this.PhotometryChart.Text = "Photometry";
            this.PhotometryChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PhotometryChart_MouseClick);
            // 
            // SubframeGroupBox
            // 
            this.SubframeGroupBox.Controls.Add(this.groupBox4);
            this.SubframeGroupBox.Controls.Add(this.groupBox2);
            this.SubframeGroupBox.Controls.Add(this.groupBox5);
            this.SubframeGroupBox.Location = new System.Drawing.Point(715, 140);
            this.SubframeGroupBox.Name = "SubframeGroupBox";
            this.SubframeGroupBox.Size = new System.Drawing.Size(323, 269);
            this.SubframeGroupBox.TabIndex = 55;
            this.SubframeGroupBox.TabStop = false;
            this.SubframeGroupBox.Text = "Subframe Calculator";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.AntseyTotalFramesLabel);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.SLambdaLabel);
            this.groupBox4.Controls.Add(this.TotalFrames);
            this.groupBox4.Controls.Add(this.SessionHoursBox);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.MinFaintADU);
            this.groupBox4.Controls.Add(this.AnExpTotalTimeLabel);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(6, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(311, 115);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Antsey Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Exposure (sec)";
            // 
            // AntseyTotalFramesLabel
            // 
            this.AntseyTotalFramesLabel.AutoSize = true;
            this.AntseyTotalFramesLabel.Location = new System.Drawing.Point(255, 83);
            this.AntseyTotalFramesLabel.Name = "AntseyTotalFramesLabel";
            this.AntseyTotalFramesLabel.Size = new System.Drawing.Size(29, 13);
            this.AntseyTotalFramesLabel.TabIndex = 62;
            this.AntseyTotalFramesLabel.Text = "TBD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "- If Desired Imaging Hours";
            // 
            // SLambdaLabel
            // 
            this.SLambdaLabel.AutoSize = true;
            this.SLambdaLabel.Location = new System.Drawing.Point(10, 33);
            this.SLambdaLabel.Name = "SLambdaLabel";
            this.SLambdaLabel.Size = new System.Drawing.Size(126, 13);
            this.SLambdaLabel.TabIndex = 9;
            this.SLambdaLabel.Text = "For Minimum Target ADU";
            // 
            // TotalFrames
            // 
            this.TotalFrames.Location = new System.Drawing.Point(169, 82);
            this.TotalFrames.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.TotalFrames.Name = "TotalFrames";
            this.TotalFrames.Size = new System.Drawing.Size(50, 20);
            this.TotalFrames.TabIndex = 59;
            this.TotalFrames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalFrames.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.TotalFrames.ValueChanged += new System.EventHandler(this.TotalFrames_ValueChanged);
            // 
            // SessionHoursBox
            // 
            this.SessionHoursBox.DecimalPlaces = 1;
            this.SessionHoursBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SessionHoursBox.Location = new System.Drawing.Point(169, 56);
            this.SessionHoursBox.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.SessionHoursBox.Name = "SessionHoursBox";
            this.SessionHoursBox.Size = new System.Drawing.Size(50, 20);
            this.SessionHoursBox.TabIndex = 57;
            this.SessionHoursBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SessionHoursBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SessionHoursBox.ValueChanged += new System.EventHandler(this.SessionHoursBox_ValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(25, 84);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(138, 13);
            this.label24.TabIndex = 60;
            this.label24.Text = "- If Desired Stacked Frames";
            // 
            // MinFaintADU
            // 
            this.MinFaintADU.Location = new System.Drawing.Point(169, 31);
            this.MinFaintADU.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.MinFaintADU.Name = "MinFaintADU";
            this.MinFaintADU.Size = new System.Drawing.Size(50, 20);
            this.MinFaintADU.TabIndex = 8;
            this.MinFaintADU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinFaintADU.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.MinFaintADU.ValueChanged += new System.EventHandler(this.MinFaintADU_ValueChanged);
            // 
            // AnExpTotalTimeLabel
            // 
            this.AnExpTotalTimeLabel.AutoSize = true;
            this.AnExpTotalTimeLabel.Location = new System.Drawing.Point(255, 58);
            this.AnExpTotalTimeLabel.Name = "AnExpTotalTimeLabel";
            this.AnExpTotalTimeLabel.Size = new System.Drawing.Size(29, 13);
            this.AnExpTotalTimeLabel.TabIndex = 46;
            this.AnExpTotalTimeLabel.Text = "TBD";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.SNRPercentBox);
            this.groupBox2.Controls.Add(this.Label5);
            this.groupBox2.Controls.Add(this.CaExpLabel);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(6, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 58);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cannestra Model";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(228, 10);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 13);
            this.label27.TabIndex = 40;
            this.label27.Text = "Exposure (sec)";
            // 
            // SNRPercentBox
            // 
            this.SNRPercentBox.DecimalPlaces = 2;
            this.SNRPercentBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SNRPercentBox.Location = new System.Drawing.Point(169, 23);
            this.SNRPercentBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SNRPercentBox.Name = "SNRPercentBox";
            this.SNRPercentBox.Size = new System.Drawing.Size(50, 20);
            this.SNRPercentBox.TabIndex = 10;
            this.SNRPercentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SNRPercentBox.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.SNRPercentBox.ValueChanged += new System.EventHandler(this.SNRTgtBox_ValueChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(9, 30);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(148, 13);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "For Maximum Fraction of SNR";
            // 
            // CaExpLabel
            // 
            this.CaExpLabel.AutoSize = true;
            this.CaExpLabel.Location = new System.Drawing.Point(255, 30);
            this.CaExpLabel.Name = "CaExpLabel";
            this.CaExpLabel.Size = new System.Drawing.Size(29, 13);
            this.CaExpLabel.TabIndex = 47;
            this.CaExpLabel.Text = "TBD";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox5.Controls.Add(this.Label2);
            this.groupBox5.Controls.Add(this.MaxReadNoiseBox);
            this.groupBox5.Controls.Add(this.SmExpLabel);
            this.groupBox5.Controls.Add(this.Label4);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(6, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(311, 58);
            this.groupBox5.TabIndex = 56;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Smith Model";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(139, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "For Maximum Read Noise %";
            // 
            // MaxReadNoiseBox
            // 
            this.MaxReadNoiseBox.Location = new System.Drawing.Point(169, 25);
            this.MaxReadNoiseBox.Name = "MaxReadNoiseBox";
            this.MaxReadNoiseBox.Size = new System.Drawing.Size(50, 20);
            this.MaxReadNoiseBox.TabIndex = 4;
            this.MaxReadNoiseBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxReadNoiseBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MaxReadNoiseBox.ValueChanged += new System.EventHandler(this.MaxNoiseBox_ValueChanged);
            // 
            // SmExpLabel
            // 
            this.SmExpLabel.AutoSize = true;
            this.SmExpLabel.Location = new System.Drawing.Point(255, 32);
            this.SmExpLabel.Name = "SmExpLabel";
            this.SmExpLabel.Size = new System.Drawing.Size(29, 13);
            this.SmExpLabel.TabIndex = 45;
            this.SmExpLabel.Text = "TBD";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(228, 6);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(77, 13);
            this.Label4.TabIndex = 40;
            this.Label4.Text = "Exposure (sec)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(863, 49);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 13);
            this.Label1.TabIndex = 36;
            this.Label1.Text = "Read Noise (e-)";
            // 
            // ReadNoiseBox
            // 
            this.ReadNoiseBox.DecimalPlaces = 1;
            this.ReadNoiseBox.Location = new System.Drawing.Point(952, 47);
            this.ReadNoiseBox.Name = "ReadNoiseBox";
            this.ReadNoiseBox.Size = new System.Drawing.Size(53, 20);
            this.ReadNoiseBox.TabIndex = 35;
            this.ReadNoiseBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReadNoiseBox.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.ReadNoiseBox.ValueChanged += new System.EventHandler(this.RNoiseBox_ValueChanged);
            // 
            // GainLabel
            // 
            this.GainLabel.AutoSize = true;
            this.GainLabel.Location = new System.Drawing.Point(863, 24);
            this.GainLabel.Name = "GainLabel";
            this.GainLabel.Size = new System.Drawing.Size(75, 13);
            this.GainLabel.TabIndex = 34;
            this.GainLabel.Text = "Gain (e-/ADU)";
            // 
            // GainBox
            // 
            this.GainBox.DecimalPlaces = 2;
            this.GainBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.GainBox.Location = new System.Drawing.Point(952, 21);
            this.GainBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GainBox.Name = "GainBox";
            this.GainBox.Size = new System.Drawing.Size(53, 20);
            this.GainBox.TabIndex = 33;
            this.GainBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GainBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GainBox.ValueChanged += new System.EventHandler(this.GainBox_ValueChanged);
            // 
            // InstrumentationGroupBox
            // 
            this.InstrumentationGroupBox.Controls.Add(this.AiryDiskmicronBox);
            this.InstrumentationGroupBox.Controls.Add(this.label18);
            this.InstrumentationGroupBox.Controls.Add(this.label16);
            this.InstrumentationGroupBox.Controls.Add(this.PerfectPixelArcSecBox);
            this.InstrumentationGroupBox.Controls.Add(this.label13);
            this.InstrumentationGroupBox.Controls.Add(this.MaxResolutionArcSecBox);
            this.InstrumentationGroupBox.Controls.Add(this.label15);
            this.InstrumentationGroupBox.Controls.Add(this.PixSizeArcSecBox);
            this.InstrumentationGroupBox.Controls.Add(this.label14);
            this.InstrumentationGroupBox.Controls.Add(this.PerfectPixelMicronBox);
            this.InstrumentationGroupBox.Controls.Add(this.PixSizeMicronBox);
            this.InstrumentationGroupBox.Controls.Add(this.FocalRatioBox);
            this.InstrumentationGroupBox.Controls.Add(this.Label1);
            this.InstrumentationGroupBox.Controls.Add(this.AiryDiskarcsecBox);
            this.InstrumentationGroupBox.Controls.Add(this.ReadNoiseBox);
            this.InstrumentationGroupBox.Controls.Add(this.ApertureBox);
            this.InstrumentationGroupBox.Controls.Add(this.GainLabel);
            this.InstrumentationGroupBox.Controls.Add(this.FocalLengthBox);
            this.InstrumentationGroupBox.Controls.Add(this.GainBox);
            this.InstrumentationGroupBox.Controls.Add(this.label12);
            this.InstrumentationGroupBox.Controls.Add(this.label11);
            this.InstrumentationGroupBox.Controls.Add(this.AiryDiskLabel);
            this.InstrumentationGroupBox.Controls.Add(this.label10);
            this.InstrumentationGroupBox.Controls.Add(this.label3);
            this.InstrumentationGroupBox.Location = new System.Drawing.Point(12, 46);
            this.InstrumentationGroupBox.Name = "InstrumentationGroupBox";
            this.InstrumentationGroupBox.Size = new System.Drawing.Size(1026, 86);
            this.InstrumentationGroupBox.TabIndex = 56;
            this.InstrumentationGroupBox.TabStop = false;
            this.InstrumentationGroupBox.Text = "Instrumentation";
            // 
            // AiryDiskmicronBox
            // 
            this.AiryDiskmicronBox.Location = new System.Drawing.Point(635, 20);
            this.AiryDiskmicronBox.Name = "AiryDiskmicronBox";
            this.AiryDiskmicronBox.Size = new System.Drawing.Size(40, 20);
            this.AiryDiskmicronBox.TabIndex = 81;
            this.AiryDiskmicronBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PerfectPixelArcSecBox
            // 
            this.PerfectPixelArcSecBox.Location = new System.Drawing.Point(805, 45);
            this.PerfectPixelArcSecBox.Name = "PerfectPixelArcSecBox";
            this.PerfectPixelArcSecBox.Size = new System.Drawing.Size(40, 20);
            this.PerfectPixelArcSecBox.TabIndex = 76;
            this.PerfectPixelArcSecBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaxResolutionArcSecBox
            // 
            this.MaxResolutionArcSecBox.Location = new System.Drawing.Point(295, 45);
            this.MaxResolutionArcSecBox.Name = "MaxResolutionArcSecBox";
            this.MaxResolutionArcSecBox.Size = new System.Drawing.Size(40, 20);
            this.MaxResolutionArcSecBox.TabIndex = 71;
            this.MaxResolutionArcSecBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PixSizeArcSecBox
            // 
            this.PixSizeArcSecBox.Location = new System.Drawing.Point(465, 45);
            this.PixSizeArcSecBox.Name = "PixSizeArcSecBox";
            this.PixSizeArcSecBox.Size = new System.Drawing.Size(40, 20);
            this.PixSizeArcSecBox.TabIndex = 69;
            this.PixSizeArcSecBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PixSizeMicronBox
            // 
            this.PixSizeMicronBox.Location = new System.Drawing.Point(465, 20);
            this.PixSizeMicronBox.Name = "PixSizeMicronBox";
            this.PixSizeMicronBox.Size = new System.Drawing.Size(40, 20);
            this.PixSizeMicronBox.TabIndex = 67;
            this.PixSizeMicronBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FocalRatioBox
            // 
            this.FocalRatioBox.Location = new System.Drawing.Point(295, 20);
            this.FocalRatioBox.Name = "FocalRatioBox";
            this.FocalRatioBox.Size = new System.Drawing.Size(40, 20);
            this.FocalRatioBox.TabIndex = 66;
            this.FocalRatioBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ApertureBox
            // 
            this.ApertureBox.Location = new System.Drawing.Point(125, 45);
            this.ApertureBox.Name = "ApertureBox";
            this.ApertureBox.Size = new System.Drawing.Size(40, 20);
            this.ApertureBox.TabIndex = 65;
            this.ApertureBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FocalLengthBox
            // 
            this.FocalLengthBox.Location = new System.Drawing.Point(125, 20);
            this.FocalLengthBox.Name = "FocalLengthBox";
            this.FocalLengthBox.Size = new System.Drawing.Size(40, 20);
            this.FocalLengthBox.TabIndex = 57;
            this.FocalLengthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VariationGraph
            // 
            this.VariationGraph.BackColor = System.Drawing.Color.LightCyan;
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisX.LabelStyle.Format = "0.0";
            chartArea3.AxisX.Title = "Magnitude History (Adjusted)";
            chartArea3.AxisX2.IsStartedFromZero = false;
            chartArea3.AxisY.IsReversed = true;
            chartArea3.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea3.AxisY.Title = "Sample Date";
            chartArea3.Name = "VariationChart";
            this.VariationGraph.ChartAreas.Add(chartArea3);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.VariationGraph.Legends.Add(legend2);
            this.VariationGraph.Location = new System.Drawing.Point(717, 463);
            this.VariationGraph.Name = "VariationGraph";
            series3.ChartArea = "VariationChart";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series3.Legend = "Legend1";
            series3.Name = "VariationSeries";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.VariationGraph.Series.Add(series3);
            this.VariationGraph.Size = new System.Drawing.Size(325, 391);
            this.VariationGraph.TabIndex = 57;
            this.VariationGraph.Text = "Star Variation";
            // 
            // PhotoStarBox
            // 
            this.PhotoStarBox.Location = new System.Drawing.Point(774, 427);
            this.PhotoStarBox.Name = "PhotoStarBox";
            this.PhotoStarBox.Size = new System.Drawing.Size(152, 20);
            this.PhotoStarBox.TabIndex = 89;
            this.PhotoStarBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhotoFilterBox
            // 
            this.PhotoFilterBox.Location = new System.Drawing.Point(979, 427);
            this.PhotoFilterBox.Name = "PhotoFilterBox";
            this.PhotoFilterBox.Size = new System.Drawing.Size(38, 20);
            this.PhotoFilterBox.TabIndex = 91;
            this.PhotoFilterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OpenFileNameBox
            // 
            this.OpenFileNameBox.Location = new System.Drawing.Point(388, 17);
            this.OpenFileNameBox.Name = "OpenFileNameBox";
            this.OpenFileNameBox.Size = new System.Drawing.Size(442, 20);
            this.OpenFileNameBox.TabIndex = 99;
            this.OpenFileNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OpenFileNameBox.TextChanged += new System.EventHandler(this.OpenFileNameBox_TextChanged);
            // 
            // OverviewButton
            // 
            this.OverviewButton.Location = new System.Drawing.Point(873, 16);
            this.OverviewButton.Name = "OverviewButton";
            this.OverviewButton.Size = new System.Drawing.Size(75, 23);
            this.OverviewButton.TabIndex = 98;
            this.OverviewButton.Text = "Overview";
            this.OverviewButton.UseVisualStyleBackColor = true;
            this.OverviewButton.Click += new System.EventHandler(this.OverviewButton_Click);
            // 
            // OnTopCheckBox
            // 
            this.OnTopCheckBox.AutoSize = true;
            this.OnTopCheckBox.Location = new System.Drawing.Point(112, 19);
            this.OnTopCheckBox.Name = "OnTopCheckBox";
            this.OnTopCheckBox.Size = new System.Drawing.Size(62, 17);
            this.OnTopCheckBox.TabIndex = 97;
            this.OnTopCheckBox.Text = "On Top";
            this.OnTopCheckBox.UseVisualStyleBackColor = true;
            this.OnTopCheckBox.CheckedChanged += new System.EventHandler(this.OnTopCheckBox_CheckedChanged);
            // 
            // FormSeeingAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1059, 873);
            this.Controls.Add(this.OpenFileNameBox);
            this.Controls.Add(this.OverviewButton);
            this.Controls.Add(this.OnTopCheckBox);
            this.Controls.Add(this.AttachButton);
            this.Controls.Add(this.OpenFitsButton);
            this.Controls.Add(this.ReadMeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PhotoFilterBox);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.PhotoStarBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.VariationGraph);
            this.Controls.Add(this.InstrumentationGroupBox);
            this.Controls.Add(this.SubframeGroupBox);
            this.Controls.Add(this.PhotometryChart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StarADUChart);
            this.Controls.Add(this.PhotometryGroupBox);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormSeeingAnalyzer";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.StarADUChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PhotometryGroupBox.ResumeLayout(false);
            this.PhotometryGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotometryChart)).EndInit();
            this.SubframeGroupBox.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionHoursBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinFaintADU)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SNRPercentBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxReadNoiseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadNoiseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GainBox)).EndInit();
            this.InstrumentationGroupBox.ResumeLayout(false);
            this.InstrumentationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariationGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label MaxADULabel;
        internal System.Windows.Forms.ToolTip AnalysisToolTips;
        internal System.Windows.Forms.Label YLabel;
        internal System.Windows.Forms.Label XLabel;
        internal System.Windows.Forms.Label CatMagLabel;
        private System.Windows.Forms.Label SeeingClassLabel;
        private System.Windows.Forms.Label SeeingLabel;
        private System.Windows.Forms.Label AiryDiskLabel;
        internal System.Windows.Forms.Label Ellipticity;
        internal System.Windows.Forms.Label RALabel;
        internal System.Windows.Forms.Label MagZeroPtLabel;
        internal System.Windows.Forms.Label FWHMLabel;
        internal System.Windows.Forms.Label DecLabel;
        internal System.Windows.Forms.Button BackButton;
        internal System.Windows.Forms.Button NextButton;
        internal System.Windows.Forms.DataVisualization.Charting.Chart StarADUChart;
        internal System.Windows.Forms.Label InstMag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox PhotometryGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart PhotometryChart;
        private System.Windows.Forms.OpenFileDialog OpenFitsDialog;
        internal System.Windows.Forms.Label BackgroundLabel;
        internal System.Windows.Forms.Label AvgMagZeroOffsetLabel;
        internal System.Windows.Forms.Label StarCountLabel;
        internal System.Windows.Forms.Label MeanMInInstMagLabel;
        internal System.Windows.Forms.Label MeanMinCatMagLabel;
        internal System.Windows.Forms.Label ExposureLabel;
        internal System.Windows.Forms.Label CoreMagRatioLabel;
        private System.Windows.Forms.GroupBox SubframeGroupBox;
        internal System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.NumericUpDown SNRPercentBox;
        internal System.Windows.Forms.Label SLambdaLabel;
        internal System.Windows.Forms.NumericUpDown MinFaintADU;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.NumericUpDown MaxReadNoiseBox;
        internal System.Windows.Forms.Label CaExpLabel;
        internal System.Windows.Forms.Label AnExpTotalTimeLabel;
        internal System.Windows.Forms.Label SmExpLabel;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.NumericUpDown ReadNoiseBox;
        internal System.Windows.Forms.Label GainLabel;
        internal System.Windows.Forms.NumericUpDown GainBox;
        internal System.Windows.Forms.Label MeanEllipsicityLabel;
        private System.Windows.Forms.TextBox MeanFWHMBox;
        private System.Windows.Forms.TextBox MeanEllipticityBox;
        private System.Windows.Forms.TextBox SeeingClassBox;
        private System.Windows.Forms.TextBox PerfectPixelMicronBox;
        private System.Windows.Forms.TextBox AiryDiskarcsecBox;
        private System.Windows.Forms.GroupBox InstrumentationGroupBox;
        private System.Windows.Forms.TextBox PixSizeMicronBox;
        private System.Windows.Forms.TextBox FocalRatioBox;
        private System.Windows.Forms.TextBox ApertureBox;
        private System.Windows.Forms.TextBox FocalLengthBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PixSizeArcSecBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox MaxResolutionArcSecBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox PerfectPixelArcSecBox;
        private System.Windows.Forms.TextBox AiryDiskmicronBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox MeanCatInstMagRatioBox;
        private System.Windows.Forms.TextBox BackgroundADUBox;
        private System.Windows.Forms.TextBox MeanCatInstMagDeltaBox;
        private System.Windows.Forms.TextBox CatLimitingMagBox;
        private System.Windows.Forms.TextBox InstLimitingMagBox;
        private System.Windows.Forms.TextBox ExposureBox;
        private System.Windows.Forms.TextBox StarCountBox;
        private System.Windows.Forms.TextBox StarYBox;
        private System.Windows.Forms.TextBox StarDecBox;
        private System.Windows.Forms.TextBox StarXBox;
        private System.Windows.Forms.TextBox StarRABox;
        private System.Windows.Forms.TextBox StarCatMagDeltaBox;
        private System.Windows.Forms.TextBox StarEllipticityBox;
        private System.Windows.Forms.TextBox StarPeakADUBox;
        private System.Windows.Forms.TextBox StarFWHMBox;
        private System.Windows.Forms.TextBox StarCatMagBox;
        private System.Windows.Forms.TextBox StarInstMagBox;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.NumericUpDown SessionHoursBox;
        private System.Windows.Forms.TextBox FileTimeBox;
        internal System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox FileDateBox;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TargetBox;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataVisualization.Charting.Chart VariationGraph;
        private System.Windows.Forms.TextBox PhotoStarBox;
        internal System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox PhotoFilterBox;
        internal System.Windows.Forms.Label label23;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.NumericUpDown TotalFrames;
        internal System.Windows.Forms.Label AntseyTotalFramesLabel;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox6;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OpenFileNameBox;
        internal System.Windows.Forms.Button OverviewButton;
        private System.Windows.Forms.CheckBox OnTopCheckBox;
        internal System.Windows.Forms.Button AttachButton;
        internal System.Windows.Forms.Button OpenFitsButton;
        internal System.Windows.Forms.Button ReadMeButton;
        internal System.Windows.Forms.Button CloseButton;
    }
}

