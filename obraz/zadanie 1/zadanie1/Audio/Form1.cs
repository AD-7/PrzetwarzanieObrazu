using Audio.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Audio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            AudioHelper audioHelper = new AudioHelper();

            short[] sample1;

            Tuple<double[], int, TimeSpan> wave = audioHelper.openWav(Path.GetSoundPath(), out sample1);
            double[] result = wave.Item1;
            //result = audioHelper.TriangleWindow(result);
            double sampleRate = Convert.ToDouble(wave.Item2);
            int seconds = wave.Item3.Seconds;
            Signal.Series.Clear();
            Signal.Series.Add("Value");
            Signal.Series["Value"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            Signal.Series["Value"].MarkerSize = 2;

          //  Signal.ChartAreas[0].AxisX.Maximum = seconds;
            //  Signal.ChartAreas[0].AxisX.Minimum = 0;
            // Signal.ChartAreas[0].AxisY.Maximum = 0.1;
            // Signal.ChartAreas[0].AxisY.Minimum = -0.1;

            double[] time = new double[result.Length];
            double[] value = new double[result.Length];
            double[] freq = new double[result.Length];

            for (int i = 0; i < result.Count(); i++)
            {
                value[i] = result[i] / sampleRate;
                time[i] = i / sampleRate;
                //freq[i] = i * sampleRate / result.Length;           // to jest do widma amplitudowego
                Signal.Series["Value"].Points.AddXY(time[i], value[i]);

                //if (value[i] > 0.008)
                //{
                //    double tmp = freq[i];
                //}
            }

        }
    }
}