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
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessValue)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.brightnessValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.brightnessValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.brightnessValue.Name = "brightnessValue";
            this.brightnessValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartLUT);
            this.groupBox2.Controls.Add(this.btnClearContrast);
            this.groupBox2.Controls.Add(this.btnApplyContrast);
            this.groupBox2.Controls.Add(this.trackBarContrast);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
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
            this.trackBarContrast.LargeChange = 2;
            resources.ApplyResources(this.trackBarContrast, "trackBarContrast");
            this.trackBarContrast.Maximum = 255;
            this.trackBarContrast.Minimum = -255;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.SmallChange = 2;
            this.trackBarContrast.TickStyle = System.Windows.Forms.TickStyle.None;
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
            this.cmbMaskSize.Items.AddRange(new object[] {
            resources.GetString("cmbMaskSize.Items"),
            resources.GetString("cmbMaskSize.Items1"),
            resources.GetString("cmbMaskSize.Items2")});
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
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brightnessValue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pbResultImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown brightnessValue;
        private System.Windows.Forms.Button btnDecreaseBrigthness;
        private System.Windows.Forms.Button btnIncreaseBrightness;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.Button btnApplyContrast;
        private System.Windows.Forms.Button btnClearContrast;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLUT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnApplyNegative;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaskSize;
        private System.Windows.Forms.Button btnApplyAverageFilter;
        private System.Windows.Forms.Button btnApplyMedianFilter;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

