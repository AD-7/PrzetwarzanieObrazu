namespace Zadanie_1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pbResultImage = new System.Windows.Forms.PictureBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDecreaseBrigthness = new System.Windows.Forms.Button();
            this.btnIncreaseBrightness = new System.Windows.Forms.Button();
            this.brightnessValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxContrast = new System.Windows.Forms.TextBox();
            this.chartLUT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClearContrast = new System.Windows.Forms.Button();
            this.btnApplyContrast = new System.Windows.Forms.Button();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnApplyNegative = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnApplyMedianFilter = new System.Windows.Forms.Button();
            this.btnApplyAverageFilter = new System.Windows.Forms.Button();
            this.cmbMaskSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbTypeLinearMask = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaskView = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbMaskSizeLinear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnHistogramSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maximalBrightnessHistogram = new System.Windows.Forms.NumericUpDown();
            this.minimalBrightnessHistogram = new System.Windows.Forms.NumericUpDown();
            this.btnHistogramModify = new System.Windows.Forms.Button();
            this.btnCalculateHistogram = new System.Windows.Forms.Button();
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOperator = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.valueRosenfeld = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numL = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numK = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.numRadius2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numRadius = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.pbFilterMask = new System.Windows.Forms.PictureBox();
            this.btnIDFT = new System.Windows.Forms.Button();
            this.pbDFT = new System.Windows.Forms.PictureBox();
            this.btnDFT = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.segMaskButton = new System.Windows.Forms.Button();
            this.segCurrentColorLabel = new System.Windows.Forms.Label();
            this.segColorsLabel = new System.Windows.Forms.Label();
            this.segAddColorButton = new System.Windows.Forms.Button();
            this.segThresholdText = new System.Windows.Forms.TextBox();
            this.segTresholdLabel = new System.Windows.Forms.Label();
            this.segYText = new System.Windows.Forms.TextBox();
            this.segXText = new System.Windows.Forms.TextBox();
            this.segYLabel = new System.Windows.Forms.Label();
            this.segXLabel = new System.Windows.Forms.Label();
            this.segHeightLabel = new System.Windows.Forms.Label();
            this.segWidthLabel = new System.Windows.Forms.Label();
            this.segStartButton = new System.Windows.Forms.Button();
            this.segThresholdLabel = new System.Windows.Forms.Label();
            this.segColorsList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbResultImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.brightnessValue)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.chartLUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarContrast)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.maximalBrightnessHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.minimalBrightnessHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.chartHistogram)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.valueRosenfeld)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numRadius2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbFilterMask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbDFT)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.pbImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbResultImage, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // pbImage
            // 
            resources.ApplyResources(this.pbImage, "pbImage");
            this.pbImage.Name = "pbImage";
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // pbResultImage
            // 
            resources.ApplyResources(this.pbResultImage, "pbResultImage");
            this.pbResultImage.Name = "pbResultImage";
            this.pbResultImage.TabStop = false;
            this.pbResultImage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbResultImage_MouseDoubleClick);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDecreaseBrigthness);
            this.groupBox1.Controls.Add(this.btnIncreaseBrightness);
            this.groupBox1.Controls.Add(this.brightnessValue);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnDecreaseBrigthness
            // 
            resources.ApplyResources(this.btnDecreaseBrigthness, "btnDecreaseBrigthness");
            this.btnDecreaseBrigthness.Name = "btnDecreaseBrigthness";
            this.btnDecreaseBrigthness.UseVisualStyleBackColor = true;
            this.btnDecreaseBrigthness.Click += new System.EventHandler(this.btnDecreaseBrigthness_Click);
            // 
            // btnIncreaseBrightness
            // 
            this.btnIncreaseBrightness.Cursor = System.Windows.Forms.Cursors.UpArrow;
            resources.ApplyResources(this.btnIncreaseBrightness, "btnIncreaseBrightness");
            this.btnIncreaseBrightness.Name = "btnIncreaseBrightness";
            this.btnIncreaseBrightness.UseVisualStyleBackColor = true;
            this.btnIncreaseBrightness.Click += new System.EventHandler(this.btnIncreaseBrightness_Click);
            // 
            // brightnessValue
            // 
            this.brightnessValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.brightnessValue, "brightnessValue");
            this.brightnessValue.Maximum = new decimal(new int[] {255, 0, 0, 0});
            this.brightnessValue.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.brightnessValue.Name = "brightnessValue";
            this.brightnessValue.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxContrast);
            this.groupBox2.Controls.Add(this.chartLUT);
            this.groupBox2.Controls.Add(this.btnClearContrast);
            this.groupBox2.Controls.Add(this.btnApplyContrast);
            this.groupBox2.Controls.Add(this.trackBarContrast);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // textBoxContrast
            // 
            resources.ApplyResources(this.textBoxContrast, "textBoxContrast");
            this.textBoxContrast.Name = "textBoxContrast";
            this.textBoxContrast.TextChanged += new System.EventHandler(this.textBoxContrast_TextChanged);
            // 
            // chartLUT
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLUT.ChartAreas.Add(chartArea1);
            resources.ApplyResources(this.chartLUT, "chartLUT");
            legend1.Name = "Legend1";
            this.chartLUT.Legends.Add(legend1);
            this.chartLUT.Name = "chartLUT";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartLUT.Series.Add(series1);
            // 
            // btnClearContrast
            // 
            resources.ApplyResources(this.btnClearContrast, "btnClearContrast");
            this.btnClearContrast.Name = "btnClearContrast";
            this.btnClearContrast.UseVisualStyleBackColor = true;
            this.btnClearContrast.Click += new System.EventHandler(this.btnClearContrast_Click);
            // 
            // btnApplyContrast
            // 
            resources.ApplyResources(this.btnApplyContrast, "btnApplyContrast");
            this.btnApplyContrast.Name = "btnApplyContrast";
            this.btnApplyContrast.UseVisualStyleBackColor = true;
            this.btnApplyContrast.Click += new System.EventHandler(this.btnApplyContrast_Click);
            // 
            // trackBarContrast
            // 
            resources.ApplyResources(this.trackBarContrast, "trackBarContrast");
            this.trackBarContrast.LargeChange = 2;
            this.trackBarContrast.Maximum = 255;
            this.trackBarContrast.Minimum = -255;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.SmallChange = 2;
            this.trackBarContrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarContrast.ValueChanged += new System.EventHandler(this.trackBarContrast_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnApplyNegative);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btnApplyNegative
            // 
            resources.ApplyResources(this.btnApplyNegative, "btnApplyNegative");
            this.btnApplyNegative.Name = "btnApplyNegative";
            this.btnApplyNegative.UseVisualStyleBackColor = true;
            this.btnApplyNegative.Click += new System.EventHandler(this.btnApplyNegative_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnApplyMedianFilter);
            this.groupBox4.Controls.Add(this.btnApplyAverageFilter);
            this.groupBox4.Controls.Add(this.cmbMaskSize);
            this.groupBox4.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // btnApplyMedianFilter
            // 
            resources.ApplyResources(this.btnApplyMedianFilter, "btnApplyMedianFilter");
            this.btnApplyMedianFilter.Name = "btnApplyMedianFilter";
            this.btnApplyMedianFilter.UseVisualStyleBackColor = true;
            this.btnApplyMedianFilter.Click += new System.EventHandler(this.btnApplyMedianFilter_Click);
            // 
            // btnApplyAverageFilter
            // 
            resources.ApplyResources(this.btnApplyAverageFilter, "btnApplyAverageFilter");
            this.btnApplyAverageFilter.Name = "btnApplyAverageFilter";
            this.btnApplyAverageFilter.UseVisualStyleBackColor = true;
            this.btnApplyAverageFilter.Click += new System.EventHandler(this.btnApplyAverageFilter_Click);
            // 
            // cmbMaskSize
            // 
            this.cmbMaskSize.FormattingEnabled = true;
            this.cmbMaskSize.Items.AddRange(new object[] {resources.GetString("cmbMaskSize.Items"), resources.GetString("cmbMaskSize.Items1"), resources.GetString("cmbMaskSize.Items2"), resources.GetString("cmbMaskSize.Items3"), resources.GetString("cmbMaskSize.Items4"), resources.GetString("cmbMaskSize.Items5")});
            resources.ApplyResources(this.cmbMaskSize, "cmbMaskSize");
            this.cmbMaskSize.Name = "cmbMaskSize";
            this.cmbMaskSize.SelectedIndexChanged += new System.EventHandler(this.cmbRozmiarMaski_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnSaveImage
            // 
            resources.ApplyResources(this.btnSaveImage, "btnSaveImage");
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbTypeLinearMask);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.tbMaskView);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.cmbMaskSizeLinear);
            this.groupBox5.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // cmbTypeLinearMask
            // 
            this.cmbTypeLinearMask.FormattingEnabled = true;
            this.cmbTypeLinearMask.Items.AddRange(new object[] {resources.GetString("cmbTypeLinearMask.Items"), resources.GetString("cmbTypeLinearMask.Items1"), resources.GetString("cmbTypeLinearMask.Items2"), resources.GetString("cmbTypeLinearMask.Items3"), resources.GetString("cmbTypeLinearMask.Items4"), resources.GetString("cmbTypeLinearMask.Items5"), resources.GetString("cmbTypeLinearMask.Items6"), resources.GetString("cmbTypeLinearMask.Items7")});
            resources.ApplyResources(this.cmbTypeLinearMask, "cmbTypeLinearMask");
            this.cmbTypeLinearMask.Name = "cmbTypeLinearMask";
            this.cmbTypeLinearMask.SelectedIndexChanged += new System.EventHandler(this.cmbTypeLinearMask_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbMaskView
            // 
            resources.ApplyResources(this.tbMaskView, "tbMaskView");
            this.tbMaskView.Name = "tbMaskView";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbMaskSizeLinear
            // 
            this.cmbMaskSizeLinear.FormattingEnabled = true;
            this.cmbMaskSizeLinear.Items.AddRange(new object[] {resources.GetString("cmbMaskSizeLinear.Items"), resources.GetString("cmbMaskSizeLinear.Items1"), resources.GetString("cmbMaskSizeLinear.Items2"), resources.GetString("cmbMaskSizeLinear.Items3")});
            resources.ApplyResources(this.cmbMaskSizeLinear, "cmbMaskSizeLinear");
            this.cmbMaskSizeLinear.Name = "cmbMaskSizeLinear";
            this.cmbMaskSizeLinear.SelectedIndexChanged += new System.EventHandler(this.cmbMaskSizeLinear_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnHistogramSave);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.maximalBrightnessHistogram);
            this.groupBox6.Controls.Add(this.minimalBrightnessHistogram);
            this.groupBox6.Controls.Add(this.btnHistogramModify);
            this.groupBox6.Controls.Add(this.btnCalculateHistogram);
            this.groupBox6.Controls.Add(this.chartHistogram);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // btnHistogramSave
            // 
            resources.ApplyResources(this.btnHistogramSave, "btnHistogramSave");
            this.btnHistogramSave.Name = "btnHistogramSave";
            this.btnHistogramSave.UseVisualStyleBackColor = true;
            this.btnHistogramSave.Click += new System.EventHandler(this.btnHistogramSave_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // maximalBrightnessHistogram
            // 
            resources.ApplyResources(this.maximalBrightnessHistogram, "maximalBrightnessHistogram");
            this.maximalBrightnessHistogram.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.maximalBrightnessHistogram.Name = "maximalBrightnessHistogram";
            this.maximalBrightnessHistogram.Value = new decimal(new int[] {100, 0, 0, 0});
            // 
            // minimalBrightnessHistogram
            // 
            resources.ApplyResources(this.minimalBrightnessHistogram, "minimalBrightnessHistogram");
            this.minimalBrightnessHistogram.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.minimalBrightnessHistogram.Name = "minimalBrightnessHistogram";
            // 
            // btnHistogramModify
            // 
            resources.ApplyResources(this.btnHistogramModify, "btnHistogramModify");
            this.btnHistogramModify.Name = "btnHistogramModify";
            this.btnHistogramModify.UseVisualStyleBackColor = true;
            this.btnHistogramModify.Click += new System.EventHandler(this.btnHistogramModify_Click);
            // 
            // btnCalculateHistogram
            // 
            resources.ApplyResources(this.btnCalculateHistogram, "btnCalculateHistogram");
            this.btnCalculateHistogram.Name = "btnCalculateHistogram";
            this.btnCalculateHistogram.UseVisualStyleBackColor = true;
            this.btnCalculateHistogram.Click += new System.EventHandler(this.btnCalculateHistogram_Click);
            // 
            // chartHistogram
            // 
            chartArea2.Name = "ChartArea1";
            this.chartHistogram.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHistogram.Legends.Add(legend2);
            resources.ApplyResources(this.chartHistogram, "chartHistogram");
            this.chartHistogram.Name = "chartHistogram";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartHistogram.Series.Add(series2);
            // 
            // btnOperator
            // 
            resources.ApplyResources(this.btnOperator, "btnOperator");
            this.btnOperator.Name = "btnOperator";
            this.btnOperator.UseVisualStyleBackColor = true;
            this.btnOperator.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.valueRosenfeld);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.btnOperator);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // valueRosenfeld
            // 
            resources.ApplyResources(this.valueRosenfeld, "valueRosenfeld");
            this.valueRosenfeld.Maximum = new decimal(new int[] {256, 0, 0, 0});
            this.valueRosenfeld.Name = "valueRosenfeld";
            this.valueRosenfeld.Value = new decimal(new int[] {16, 0, 0, 0});
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numL);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.numK);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cmbFilter);
            this.tabPage2.Controls.Add(this.numRadius2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.numRadius);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.pbFilterMask);
            this.tabPage2.Controls.Add(this.btnIDFT);
            this.tabPage2.Controls.Add(this.pbDFT);
            this.tabPage2.Controls.Add(this.btnDFT);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numL
            // 
            resources.ApplyResources(this.numL, "numL");
            this.numL.Maximum = new decimal(new int[] {300, 0, 0, 0});
            this.numL.Name = "numL";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // numK
            // 
            resources.ApplyResources(this.numK, "numK");
            this.numK.Maximum = new decimal(new int[] {300, 0, 0, 0});
            this.numK.Name = "numK";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {resources.GetString("cmbFilter.Items"), resources.GetString("cmbFilter.Items1"), resources.GetString("cmbFilter.Items2"), resources.GetString("cmbFilter.Items3"), resources.GetString("cmbFilter.Items4"), resources.GetString("cmbFilter.Items5"), resources.GetString("cmbFilter.Items6"), resources.GetString("cmbFilter.Items7"), resources.GetString("cmbFilter.Items8"), resources.GetString("cmbFilter.Items9"), resources.GetString("cmbFilter.Items10"), resources.GetString("cmbFilter.Items11")});
            resources.ApplyResources(this.cmbFilter, "cmbFilter");
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // numRadius2
            // 
            resources.ApplyResources(this.numRadius2, "numRadius2");
            this.numRadius2.Name = "numRadius2";
            this.numRadius2.ValueChanged += new System.EventHandler(this.numRadius2_ValueChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // numRadius
            // 
            resources.ApplyResources(this.numRadius, "numRadius");
            this.numRadius.Name = "numRadius";
            this.numRadius.ValueChanged += new System.EventHandler(this.numRadius_ValueChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // pbFilterMask
            // 
            this.pbFilterMask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pbFilterMask, "pbFilterMask");
            this.pbFilterMask.Name = "pbFilterMask";
            this.pbFilterMask.TabStop = false;
            // 
            // btnIDFT
            // 
            resources.ApplyResources(this.btnIDFT, "btnIDFT");
            this.btnIDFT.Name = "btnIDFT";
            this.btnIDFT.UseVisualStyleBackColor = true;
            this.btnIDFT.Click += new System.EventHandler(this.btnIDFT_Click);
            // 
            // pbDFT
            // 
            this.pbDFT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pbDFT, "pbDFT");
            this.pbDFT.Name = "pbDFT";
            this.pbDFT.TabStop = false;
            this.pbDFT.Click += new System.EventHandler(this.pbDFT_Click);
            // 
            // btnDFT
            // 
            resources.ApplyResources(this.btnDFT, "btnDFT");
            this.btnDFT.Name = "btnDFT";
            this.btnDFT.UseVisualStyleBackColor = true;
            this.btnDFT.Click += new System.EventHandler(this.btnDFT_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.segColorsList);
            this.tabPage3.Controls.Add(this.segMaskButton);
            this.tabPage3.Controls.Add(this.segCurrentColorLabel);
            this.tabPage3.Controls.Add(this.segColorsLabel);
            this.tabPage3.Controls.Add(this.segAddColorButton);
            this.tabPage3.Controls.Add(this.segThresholdText);
            this.tabPage3.Controls.Add(this.segTresholdLabel);
            this.tabPage3.Controls.Add(this.segYText);
            this.tabPage3.Controls.Add(this.segXText);
            this.tabPage3.Controls.Add(this.segYLabel);
            this.tabPage3.Controls.Add(this.segXLabel);
            this.tabPage3.Controls.Add(this.segHeightLabel);
            this.tabPage3.Controls.Add(this.segWidthLabel);
            this.tabPage3.Controls.Add(this.segStartButton);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // segMaskButton
            // 
            resources.ApplyResources(this.segMaskButton, "segMaskButton");
            this.segMaskButton.Name = "segMaskButton";
            this.segMaskButton.UseVisualStyleBackColor = true;
            this.segMaskButton.Click += new System.EventHandler(this.segMaskButton_Click);
            // 
            // segCurrentColorLabel
            // 
            resources.ApplyResources(this.segCurrentColorLabel, "segCurrentColorLabel");
            this.segCurrentColorLabel.Name = "segCurrentColorLabel";
            // 
            // segColorsLabel
            // 
            resources.ApplyResources(this.segColorsLabel, "segColorsLabel");
            this.segColorsLabel.Name = "segColorsLabel";
            // 
            // segAddColorButton
            // 
            resources.ApplyResources(this.segAddColorButton, "segAddColorButton");
            this.segAddColorButton.Name = "segAddColorButton";
            this.segAddColorButton.UseVisualStyleBackColor = true;
            this.segAddColorButton.Click += new System.EventHandler(this.segColorsText_TextChanged);
            // 
            // segThresholdText
            // 
            resources.ApplyResources(this.segThresholdText, "segThresholdText");
            this.segThresholdText.Name = "segThresholdText";
            this.segThresholdText.TextChanged += new System.EventHandler(this.segThresholdText_TextChanged);
            // 
            // segTresholdLabel
            // 
            resources.ApplyResources(this.segTresholdLabel, "segTresholdLabel");
            this.segTresholdLabel.Name = "segTresholdLabel";
            // 
            // segYText
            // 
            resources.ApplyResources(this.segYText, "segYText");
            this.segYText.Name = "segYText";
            this.segYText.TextChanged += new System.EventHandler(this.segYText_TextChanged);
            // 
            // segXText
            // 
            resources.ApplyResources(this.segXText, "segXText");
            this.segXText.Name = "segXText";
            this.segXText.TextChanged += new System.EventHandler(this.segXText_TextChanged);
            // 
            // segYLabel
            // 
            resources.ApplyResources(this.segYLabel, "segYLabel");
            this.segYLabel.Name = "segYLabel";
            // 
            // segXLabel
            // 
            resources.ApplyResources(this.segXLabel, "segXLabel");
            this.segXLabel.Name = "segXLabel";
            // 
            // segHeightLabel
            // 
            resources.ApplyResources(this.segHeightLabel, "segHeightLabel");
            this.segHeightLabel.Name = "segHeightLabel";
            // 
            // segWidthLabel
            // 
            resources.ApplyResources(this.segWidthLabel, "segWidthLabel");
            this.segWidthLabel.Name = "segWidthLabel";
            // 
            // segStartButton
            // 
            resources.ApplyResources(this.segStartButton, "segStartButton");
            this.segStartButton.Name = "segStartButton";
            this.segStartButton.UseVisualStyleBackColor = true;
            this.segStartButton.Click += new System.EventHandler(this.segStartButton_Click);
            // 
            // segThresholdLabel
            // 
            resources.ApplyResources(this.segThresholdLabel, "segThresholdLabel");
            this.segThresholdLabel.Name = "segThresholdLabel";
            // 
            // segColorsList
            // 
            resources.ApplyResources(this.segColorsList, "segColorsList");
            this.segColorsList.Name = "segColorsList";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbResultImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.brightnessValue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.chartLUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarContrast)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.maximalBrightnessHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.minimalBrightnessHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.chartHistogram)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.valueRosenfeld)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numL)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numK)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numRadius2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbFilterMask)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbDFT)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown brightnessValue;
        private System.Windows.Forms.Button btnApplyAverageFilter;
        private System.Windows.Forms.Button btnApplyContrast;
        private System.Windows.Forms.Button btnApplyMedianFilter;
        private System.Windows.Forms.Button btnApplyNegative;
        private System.Windows.Forms.Button btnCalculateHistogram;
        private System.Windows.Forms.Button btnClearContrast;
        private System.Windows.Forms.Button btnDecreaseBrigthness;
        private System.Windows.Forms.Button btnDFT;
        private System.Windows.Forms.Button btnHistogramModify;
        private System.Windows.Forms.Button btnHistogramSave;
        private System.Windows.Forms.Button btnIDFT;
        private System.Windows.Forms.Button btnIncreaseBrightness;
        private System.Windows.Forms.Button btnOperator;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLUT;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.ComboBox cmbMaskSize;
        private System.Windows.Forms.ComboBox cmbMaskSizeLinear;
        private System.Windows.Forms.ComboBox cmbTypeLinearMask;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown maximalBrightnessHistogram;
        private System.Windows.Forms.NumericUpDown minimalBrightnessHistogram;
        private System.Windows.Forms.NumericUpDown numK;
        private System.Windows.Forms.NumericUpDown numL;
        private System.Windows.Forms.NumericUpDown numRadius;
        private System.Windows.Forms.NumericUpDown numRadius2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbDFT;
        private System.Windows.Forms.PictureBox pbFilterMask;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pbResultImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button segAddColorButton;
        private System.Windows.Forms.Label segColorsLabel;
        private System.Windows.Forms.FlowLayoutPanel segColorsList;
        private System.Windows.Forms.Label segCurrentColorLabel;
        private System.Windows.Forms.Label segHeightLabel;
        private System.Windows.Forms.Button segMaskButton;
        private System.Windows.Forms.Button segStartButton;
        private System.Windows.Forms.Label segThresholdLabel;
        private System.Windows.Forms.TextBox segThresholdText;
        private System.Windows.Forms.Label segTresholdLabel;
        private System.Windows.Forms.Label segWidthLabel;
        private System.Windows.Forms.Label segXLabel;
        private System.Windows.Forms.TextBox segXText;
        private System.Windows.Forms.Label segYLabel;
        private System.Windows.Forms.TextBox segYText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbMaskView;
        private System.Windows.Forms.TextBox textBoxContrast;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.NumericUpDown valueRosenfeld;

        #endregion
    }
}

