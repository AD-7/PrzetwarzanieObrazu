using Audio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Audio
{
    public partial class Form1 : Form
    {
        public struct CurrentSignal
        {
            public int sampleRate;
            public List<double[]> signal;
            public TimeSpan seconds;
            public CurrentSignal(int sampleRate, List<double[]> signal,TimeSpan seconds)
            {
                this.sampleRate = sampleRate;
                this.seconds = seconds;
                this.signal = signal;
            }

        }


        CurrentSignal currentSignal;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            AudioHelper audioHelper = new AudioHelper();

            short[] sample1;

            Tuple<List<double[]>, int, TimeSpan> wave = audioHelper.openWav(Path.GetSoundPath(), out sample1, 2048);

            currentSignal = new CurrentSignal(wave.Item2, wave.Item1, wave.Item3);

            RefreshSignal();

        }

        public void RefreshSignal()
        {
            double[] result = currentSignal.signal[0];
            Signal.Series.Clear();
            Signal.Series.Add("Value");
            Signal.Series["Value"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            Signal.Series["Value"].MarkerSize = 10;

            double sampleRate = Convert.ToDouble(currentSignal.sampleRate);
            int seconds = currentSignal.seconds.Seconds;

            double[] time = new double[result.Length];
            double[] value = new double[result.Length];
            double[] freq = new double[result.Length];


            for (int i = 0; i < result.Count(); i++)
            {
                value[i] = result[i] / sampleRate;
                time[i] = i / sampleRate;
                //   freq[i] = (int)(i * sampleRate / result.Length);           // to jest do widma amplitudowego
                Signal.Series["Value"].Points.AddXY(time[i], value[i]);

            }

            SignalAmplitude.Series.Clear();
            SignalAmplitude.Series.Add("Value");
            SignalAmplitude.Series["Value"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            SignalAmplitude.Series["Value"].MarkerSize = 10;

            result = AudioHelper.PreEmFaza(result);
            result = AudioHelper.toDouble(AudioHelper.FFT(AudioHelper.toComplex(result)));


            for (int i = 0; i < result.Count() / 2; i++)
            {
                value[i] = AudioHelper.LinearToDecibels(result[i] / sampleRate);
                time[i] = i / sampleRate;
                freq[i] = (int)(i * sampleRate / result.Length);           // to jest do widma amplitudowego
                SignalAmplitude.Series["Value"].Points.AddXY(freq[i], value[i]);
            }
        }
    }
}