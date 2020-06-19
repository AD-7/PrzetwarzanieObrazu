namespace AudioFiltering
{
    partial class Parameters
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
            this.btnSaveParams = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edFrameSize = new System.Windows.Forms.TextBox();
            this.edHopSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edFilterSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edCutOffFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkCasual = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edWindowType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSaveParams
            // 
            this.btnSaveParams.Location = new System.Drawing.Point(96, 288);
            this.btnSaveParams.Name = "btnSaveParams";
            this.btnSaveParams.Size = new System.Drawing.Size(75, 23);
            this.btnSaveParams.TabIndex = 0;
            this.btnSaveParams.Text = "zapisz";
            this.btnSaveParams.UseVisualStyleBackColor = true;
            this.btnSaveParams.Click += new System.EventHandler(this.btnSaveParams_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rozmiar ramki";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // edFrameSize
            // 
            this.edFrameSize.Location = new System.Drawing.Point(130, 34);
            this.edFrameSize.Name = "edFrameSize";
            this.edFrameSize.Size = new System.Drawing.Size(100, 20);
            this.edFrameSize.TabIndex = 2;
            this.edFrameSize.Text = "512";
            // 
            // edHopSize
            // 
            this.edHopSize.Location = new System.Drawing.Point(130, 74);
            this.edHopSize.Name = "edHopSize";
            this.edHopSize.Size = new System.Drawing.Size(100, 20);
            this.edHopSize.TabIndex = 4;
            this.edHopSize.Text = "256";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Przesunięcie ramki";
            // 
            // edFilterSize
            // 
            this.edFilterSize.Location = new System.Drawing.Point(130, 156);
            this.edFilterSize.Name = "edFilterSize";
            this.edFilterSize.Size = new System.Drawing.Size(100, 20);
            this.edFilterSize.TabIndex = 6;
            this.edFilterSize.Text = "511";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rozmiar filtra";
            // 
            // edCutOffFilter
            // 
            this.edCutOffFilter.Location = new System.Drawing.Point(130, 189);
            this.edCutOffFilter.Name = "edCutOffFilter";
            this.edCutOffFilter.Size = new System.Drawing.Size(100, 20);
            this.edCutOffFilter.TabIndex = 8;
            this.edCutOffFilter.Text = "321";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Częstotliwość odcięcia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rodzaj filtra";
            // 
            // chkCasual
            // 
            this.chkCasual.AutoSize = true;
            this.chkCasual.Checked = true;
            this.chkCasual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCasual.Location = new System.Drawing.Point(130, 129);
            this.chkCasual.Name = "chkCasual";
            this.chkCasual.Size = new System.Drawing.Size(87, 17);
            this.chkCasual.TabIndex = 10;
            this.chkCasual.Text = "Przyczynowy";
            this.chkCasual.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rodzaj okna";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // edWindowType
            // 
            this.edWindowType.FormattingEnabled = true;
            this.edWindowType.Items.AddRange(new object[] {
            "prostokątne",
            "vonn Hann",
            "Hamming"});
            this.edWindowType.Location = new System.Drawing.Point(130, 229);
            this.edWindowType.Name = "edWindowType";
            this.edWindowType.Size = new System.Drawing.Size(100, 21);
            this.edWindowType.TabIndex = 12;
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 323);
            this.Controls.Add(this.edWindowType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkCasual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edCutOffFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edFilterSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edHopSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edFrameSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveParams);
            this.Name = "Parameters";
            this.Text = "Parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edFrameSize;
        private System.Windows.Forms.TextBox edHopSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edFilterSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edCutOffFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCasual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox edWindowType;
    }
}