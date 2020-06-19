using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioFiltering
{
    public partial class FilterCHart : Form
    {
        float[] data;
        public FilterCHart(float[] data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void FilterCHart_Load(object sender, EventArgs e)
        {
            chartFilter.Series.Clear();
            chartFilter.Series.Add("Value");
            chartFilter.Series["Value"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartFilter.Series["Value"].MarkerSize = 1;

            for (int i = 0; i < data.Count(); i++)
            {
                float value = data[i] / 44100.0f;
                float time = i;
                //   freq[i] = (int)(i * sampleRate / result.Length);           // to jest do widma amplitudowego
                chartFilter.Series["Value"].Points.AddXY(time, value);
            }


        }
    }
}
