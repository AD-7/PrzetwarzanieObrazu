namespace Audio
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SignalAmplitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Signal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.numFrame = new System.Windows.Forms.NumericUpDown();
            this.lbramki = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numProg = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnProg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.playFreqButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.basicAudioChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.phaseSpaceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.stepLabel = new System.Windows.Forms.Label();
            this.stepTextBox = new System.Windows.Forms.TextBox();
            this.kLabel = new System.Windows.Forms.Label();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.precisionTextBox = new System.Windows.Forms.TextBox();
            this.refreshSpaceButton = new System.Windows.Forms.Button();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.playTimeButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.SignalAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Signal)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numProg)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.basicAudioChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.phaseSpaceChart)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(3, 3);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 22);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "wczytaj ";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1388, 652);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1380, 626);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Widmo amplitudowe";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.SignalAmplitude, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.Signal, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.870968F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.58064F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.225806F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.16129F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1374, 620);
            this.tableLayoutPanel2.TabIndex = 5;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sygnał:";
            // 
            // SignalAmplitude
            // 
            this.SignalAmplitude.BorderlineColor = System.Drawing.Color.Black;
            this.SignalAmplitude.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.SignalAmplitude.ChartAreas.Add(chartArea1);
            this.SignalAmplitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignalAmplitude.Location = new System.Drawing.Point(690, 89);
            this.SignalAmplitude.Name = "SignalAmplitude";
            this.SignalAmplitude.Size = new System.Drawing.Size(681, 413);
            this.SignalAmplitude.TabIndex = 0;
            this.SignalAmplitude.Text = "chart1";
            // 
            // Signal
            // 
            this.Signal.BorderlineColor = System.Drawing.Color.Black;
            this.Signal.BorderlineWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.Signal.ChartAreas.Add(chartArea2);
            this.Signal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Signal.Location = new System.Drawing.Point(3, 89);
            this.Signal.Name = "Signal";
            this.Signal.Size = new System.Drawing.Size(681, 413);
            this.Signal.TabIndex = 2;
            this.Signal.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Widmo amplitudowe:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.62849F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.09692F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.16446F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.numFrame, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbramki, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.numProg, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.97959F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.02041F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(681, 49);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // numFrame
            // 
            this.numFrame.Location = new System.Drawing.Point(3, 26);
            this.numFrame.Name = "numFrame";
            this.numFrame.Size = new System.Drawing.Size(76, 20);
            this.numFrame.TabIndex = 2;
            this.numFrame.ValueChanged += new System.EventHandler(this.numFrame_ValueChanged);
            // 
            // lbramki
            // 
            this.lbramki.AutoSize = true;
            this.lbramki.Location = new System.Drawing.Point(3, 0);
            this.lbramki.Name = "lbramki";
            this.lbramki.Size = new System.Drawing.Size(44, 13);
            this.lbramki.TabIndex = 0;
            this.lbramki.Text = "nr ramki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "próg";
            // 
            // numProg
            // 
            this.numProg.Location = new System.Drawing.Point(185, 26);
            this.numProg.Maximum = new decimal(new int[] {0, 0, 0, 0});
            this.numProg.Minimum = new decimal(new int[] {80, 0, 0, -2147483648});
            this.numProg.Name = "numProg";
            this.numProg.Size = new System.Drawing.Size(80, 20);
            this.numProg.TabIndex = 1;
            this.numProg.Value = new decimal(new int[] {40, 0, 0, -2147483648});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "wielkość ramki";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {"512", "1024", "2048", "4096", "8192", "16384"});
            this.comboBox1.Location = new System.Drawing.Point(89, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.42584F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.62849F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.251101F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.06902F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.06608F));
            this.tableLayoutPanel4.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnProg, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.playFreqButton, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox1, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(690, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(681, 49);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(73, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 43);
            this.button3.TabIndex = 10;
            this.button3.Text = "zeruj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProg
            // 
            this.btnProg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProg.Location = new System.Drawing.Point(3, 3);
            this.btnProg.Name = "btnProg";
            this.btnProg.Size = new System.Drawing.Size(64, 43);
            this.btnProg.TabIndex = 6;
            this.btnProg.Text = "zaznacz próg";
            this.btnProg.UseVisualStyleBackColor = true;
            this.btnProg.Click += new System.EventHandler(this.btnProg_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(158, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "oblicz częstotliwość";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // playFreqButton
            // 
            this.playFreqButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playFreqButton.Location = new System.Drawing.Point(220, 3);
            this.playFreqButton.Name = "playFreqButton";
            this.playFreqButton.Size = new System.Drawing.Size(82, 43);
            this.playFreqButton.TabIndex = 8;
            this.playFreqButton.Text = "graj";
            this.playFreqButton.UseVisualStyleBackColor = true;
            this.playFreqButton.Click += new System.EventHandler(this.playFreqButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.Location = new System.Drawing.Point(308, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 43);
            this.textBox1.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel5);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1380, 626);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "czas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.basicAudioChart, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.phaseSpaceChart, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.823151F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.17685F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1374, 620);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // basicAudioChart
            // 
            this.basicAudioChart.BorderlineColor = System.Drawing.Color.Black;
            this.basicAudioChart.BorderlineWidth = 2;
            chartArea3.Name = "ChartArea1";
            this.basicAudioChart.ChartAreas.Add(chartArea3);
            this.basicAudioChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicAudioChart.Location = new System.Drawing.Point(3, 32);
            this.basicAudioChart.Name = "basicAudioChart";
            this.basicAudioChart.Size = new System.Drawing.Size(681, 585);
            this.basicAudioChart.TabIndex = 6;
            this.basicAudioChart.Text = "chart1";
            // 
            // phaseSpaceChart
            // 
            this.phaseSpaceChart.BorderlineColor = System.Drawing.Color.Black;
            this.phaseSpaceChart.BorderlineWidth = 2;
            chartArea4.Name = "ChartArea1";
            this.phaseSpaceChart.ChartAreas.Add(chartArea4);
            this.phaseSpaceChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phaseSpaceChart.Location = new System.Drawing.Point(690, 32);
            this.phaseSpaceChart.Name = "phaseSpaceChart";
            this.phaseSpaceChart.Size = new System.Drawing.Size(681, 585);
            this.phaseSpaceChart.TabIndex = 4;
            this.phaseSpaceChart.Text = "chart1";
            this.phaseSpaceChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.phaseSpaceChart_MouseMove);
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.stepLabel);
            this.flowLayoutPanel1.Controls.Add(this.stepTextBox);
            this.flowLayoutPanel1.Controls.Add(this.kLabel);
            this.flowLayoutPanel1.Controls.Add(this.kTextBox);
            this.flowLayoutPanel1.Controls.Add(this.sizeLabel);
            this.flowLayoutPanel1.Controls.Add(this.sizeTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.precisionTextBox);
            this.flowLayoutPanel1.Controls.Add(this.refreshSpaceButton);
            this.flowLayoutPanel1.Controls.Add(this.frequencyLabel);
            this.flowLayoutPanel1.Controls.Add(this.playTimeButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1368, 23);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // stepLabel
            // 
            this.stepLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stepLabel.AutoSize = true;
            this.stepLabel.Location = new System.Drawing.Point(3, 8);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(29, 13);
            this.stepLabel.TabIndex = 0;
            this.stepLabel.Text = "Krok";
            // 
            // stepTextBox
            // 
            this.stepTextBox.Location = new System.Drawing.Point(38, 3);
            this.stepTextBox.Name = "stepTextBox";
            this.stepTextBox.Size = new System.Drawing.Size(97, 20);
            this.stepTextBox.TabIndex = 1;
            this.stepTextBox.Text = "1";
            // 
            // kLabel
            // 
            this.kLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(141, 8);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(13, 13);
            this.kLabel.TabIndex = 2;
            this.kLabel.Text = "k";
            this.kLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // kTextBox
            // 
            this.kTextBox.Location = new System.Drawing.Point(160, 3);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.Size = new System.Drawing.Size(97, 20);
            this.kTextBox.TabIndex = 3;
            this.kTextBox.Text = "100";
            // 
            // sizeLabel
            // 
            this.sizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(263, 8);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(45, 13);
            this.sizeLabel.TabIndex = 4;
            this.sizeLabel.Text = "Rozmiar";
            this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(314, 3);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(97, 20);
            this.sizeTextBox.TabIndex = 5;
            this.sizeTextBox.Text = "10000";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precyzja";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // precisionTextBox
            // 
            this.precisionTextBox.Location = new System.Drawing.Point(470, 3);
            this.precisionTextBox.Name = "precisionTextBox";
            this.precisionTextBox.Size = new System.Drawing.Size(97, 20);
            this.precisionTextBox.TabIndex = 9;
            this.precisionTextBox.Text = "0,000000001";
            // 
            // refreshSpaceButton
            // 
            this.refreshSpaceButton.Location = new System.Drawing.Point(573, 3);
            this.refreshSpaceButton.Name = "refreshSpaceButton";
            this.refreshSpaceButton.Size = new System.Drawing.Size(75, 23);
            this.refreshSpaceButton.TabIndex = 6;
            this.refreshSpaceButton.Text = "Odśwież";
            this.refreshSpaceButton.UseVisualStyleBackColor = true;
            this.refreshSpaceButton.Click += new System.EventHandler(this.refreshSpaceButton_Click);
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(654, 8);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(71, 13);
            this.frequencyLabel.TabIndex = 7;
            this.frequencyLabel.Text = "Częstotliwość";
            this.frequencyLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // playTimeButton
            // 
            this.playTimeButton.Location = new System.Drawing.Point(731, 3);
            this.playTimeButton.Name = "playTimeButton";
            this.playTimeButton.Size = new System.Drawing.Size(75, 23);
            this.playTimeButton.TabIndex = 10;
            this.playTimeButton.Text = "Graj";
            this.playTimeButton.UseVisualStyleBackColor = true;
            this.playTimeButton.Click += new System.EventHandler(this.playTimeButton_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineWidth = 2;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1374, 620);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnWczytaj, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.227405F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.7726F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1394, 686);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 686);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.SignalAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Signal)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numProg)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.basicAudioChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.phaseSpaceChart)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart basicAudioChart;
        private System.Windows.Forms.Button btnProg;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbramki;
        private System.Windows.Forms.NumericUpDown numFrame;
        private System.Windows.Forms.NumericUpDown numProg;
        private System.Windows.Forms.DataVisualization.Charting.Chart phaseSpaceChart;
        private System.Windows.Forms.Button playFreqButton;
        private System.Windows.Forms.Button playTimeButton;
        private System.Windows.Forms.TextBox precisionTextBox;
        private System.Windows.Forms.Button refreshSpaceButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart Signal;
        private System.Windows.Forms.DataVisualization.Charting.Chart SignalAmplitude;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.TextBox stepTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}