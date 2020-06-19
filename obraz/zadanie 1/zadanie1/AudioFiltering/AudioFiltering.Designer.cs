namespace AudioFiltering
{
    partial class AudioFiltering
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartSignal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFiltered = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.parametryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażWykresFiltruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zastosujFiltrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dziedzinaCzasuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dziedzinaCzęstotliwościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSignal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFiltered)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajToolStripMenuItem,
            this.parametryToolStripMenuItem,
            this.pokażWykresFiltruToolStripMenuItem,
            this.zastosujFiltrToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.wczytajToolStripMenuItem.Text = "Wczytaj";
            this.wczytajToolStripMenuItem.Click += new System.EventHandler(this.wczytajToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chartSignal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartFiltered, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.89338F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.01571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1005, 486);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // chartSignal
            // 
            chartArea9.Name = "ChartArea1";
            this.chartSignal.ChartAreas.Add(chartArea9);
            this.chartSignal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSignal.Location = new System.Drawing.Point(3, 3);
            this.chartSignal.Name = "chartSignal";
            this.chartSignal.Size = new System.Drawing.Size(999, 212);
            this.chartSignal.TabIndex = 0;
            this.chartSignal.Text = "chart1";
            // 
            // chartFiltered
            // 
            chartArea10.Name = "ChartArea1";
            this.chartFiltered.ChartAreas.Add(chartArea10);
            this.chartFiltered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartFiltered.Location = new System.Drawing.Point(3, 265);
            this.chartFiltered.Name = "chartFiltered";
            this.chartFiltered.Size = new System.Drawing.Size(999, 218);
            this.chartFiltered.TabIndex = 1;
            this.chartFiltered.Text = "chart1";
            // 
            // parametryToolStripMenuItem
            // 
            this.parametryToolStripMenuItem.Name = "parametryToolStripMenuItem";
            this.parametryToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.parametryToolStripMenuItem.Text = "Parametry";
            this.parametryToolStripMenuItem.Click += new System.EventHandler(this.parametryToolStripMenuItem_Click);
            // 
            // pokażWykresFiltruToolStripMenuItem
            // 
            this.pokażWykresFiltruToolStripMenuItem.Name = "pokażWykresFiltruToolStripMenuItem";
            this.pokażWykresFiltruToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.pokażWykresFiltruToolStripMenuItem.Text = "Pokaż wykres filtru";
            this.pokażWykresFiltruToolStripMenuItem.Click += new System.EventHandler(this.pokażWykresFiltruToolStripMenuItem_Click);
            // 
            // zastosujFiltrToolStripMenuItem
            // 
            this.zastosujFiltrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dziedzinaCzasuToolStripMenuItem,
            this.dziedzinaCzęstotliwościToolStripMenuItem});
            this.zastosujFiltrToolStripMenuItem.Name = "zastosujFiltrToolStripMenuItem";
            this.zastosujFiltrToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.zastosujFiltrToolStripMenuItem.Text = "Zastosuj filtr";
            // 
            // dziedzinaCzasuToolStripMenuItem
            // 
            this.dziedzinaCzasuToolStripMenuItem.Name = "dziedzinaCzasuToolStripMenuItem";
            this.dziedzinaCzasuToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dziedzinaCzasuToolStripMenuItem.Text = "dziedzina czasu";
            this.dziedzinaCzasuToolStripMenuItem.Click += new System.EventHandler(this.dziedzinaCzasuToolStripMenuItem_Click);
            // 
            // dziedzinaCzęstotliwościToolStripMenuItem
            // 
            this.dziedzinaCzęstotliwościToolStripMenuItem.Name = "dziedzinaCzęstotliwościToolStripMenuItem";
            this.dziedzinaCzęstotliwościToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dziedzinaCzęstotliwościToolStripMenuItem.Text = "dziedzina częstotliwości";
            // 
            // AudioFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AudioFiltering";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSignal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFiltered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSignal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFiltered;
        private System.Windows.Forms.ToolStripMenuItem parametryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażWykresFiltruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zastosujFiltrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dziedzinaCzasuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dziedzinaCzęstotliwościToolStripMenuItem;
    }
}

