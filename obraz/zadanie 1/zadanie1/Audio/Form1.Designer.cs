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
            this.Signal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnWczytaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Signal)).BeginInit();
            this.SuspendLayout();
            // 
            // Signal
            // 
            chartArea1.Name = "ChartArea1";
            this.Signal.ChartAreas.Add(chartArea1);
            this.Signal.Location = new System.Drawing.Point(53, 64);
            this.Signal.Name = "Signal";
            this.Signal.Size = new System.Drawing.Size(1123, 610);
            this.Signal.TabIndex = 0;
            this.Signal.Text = "chart1";
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(206, 21);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "wczytaj ";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 686);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.Signal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Signal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Signal;
        private System.Windows.Forms.Button btnWczytaj;
    }
}