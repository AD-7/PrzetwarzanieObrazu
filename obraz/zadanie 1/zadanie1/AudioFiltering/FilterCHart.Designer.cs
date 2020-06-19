namespace AudioFiltering
{
    partial class FilterCHart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chartFilter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFilter
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFilter.ChartAreas.Add(chartArea2);
            this.chartFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartFilter.Location = new System.Drawing.Point(0, 0);
            this.chartFilter.Name = "chartFilter";
            this.chartFilter.Size = new System.Drawing.Size(800, 450);
            this.chartFilter.TabIndex = 0;
            this.chartFilter.Text = "chart1";
            // 
            // FilterCHart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartFilter);
            this.Name = "FilterCHart";
            this.Text = "FilterCHart";
            this.Load += new System.EventHandler(this.FilterCHart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFilter;
    }
}