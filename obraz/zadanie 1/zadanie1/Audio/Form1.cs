using Audio.Classes;
using System;
using System.Collections.Generic;
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

            double tmp = AudioHelper.LinearToDecibels(1000);

            Tuple<List<double[]>, int, TimeSpan> wave = audioHelper.openWav(Path.GetSoundPath(), out sample1, 2048);
            double[] result = wave.Item1[5];
             result = audioHelper.PreEmFaza(result);
          

            result = AudioHelper.toDouble(AudioHelper.FFT(AudioHelper.toComplex(result)));

            double sampleRate = Convert.ToDouble(wave.Item2);
            int seconds = wave.Item3.Seconds;
            Signal.Series.Clear();
            Signal.Series.Add("Value");
            Signal.Series["Value"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            Signal.Series["Value"].MarkerSize = 10;

            //  Signal.ChartAreas[0].AxisX.Maximum = seconds;
            //  Signal.ChartAreas[0].AxisX.Minimum = 0;
            // Signal.ChartAreas[0].AxisY.Maximum = 0.1;
            // Signal.ChartAreas[0].AxisY.Minimum = -0.1;

            double[] time = new double[result.Length];
            double[] value = new double[result.Length];
            double[] freq = new double[result.Length];

            for (int i = 0; i < result.Count()/2; i++)
            {
                value[i] = AudioHelper.LinearToDecibels(result[i] / sampleRate);
                time[i] = i / sampleRate;
                freq[i] = (int)(i * sampleRate / result.Length);           // to jest do widma amplitudowego
                Signal.Series["Value"].Points.AddXY(freq[i], value[i]);

                //if (value[i] > 0.03)
                //{
                //    double tmp = freq[i];
                //}
            }

        }
    }
}