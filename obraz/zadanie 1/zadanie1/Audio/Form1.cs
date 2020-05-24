﻿using Audio.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Audio
{
    public partial class Form1 : Form
    {
        public struct CurrentSignal
        {
            public int sampleRate;
            public TimeSpan seconds;
            public bool isCalculated;

            public List<double[]> signal;
            public double[] amplitude;
            public List<List<PointF>> maksima;

            public CurrentSignal(int sampleRate, List<double[]> signal, TimeSpan seconds)
            {
                this.sampleRate = sampleRate;
                this.seconds = seconds;
                this.signal = signal;
                this.amplitude = new double[signal[0].Length];
                isCalculated = false;
                maksima = new List<List<PointF>>();
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
            numFrame.Minimum = 0;
            numFrame.Maximum = currentSignal.signal.Count - 1;
            lbramki.Text = "Nr ramki: (max. " + numFrame.Maximum + ")";
            RefreshSignal(0);

        }

        public void RefreshSignal(int frame)
        {
            double[] result = currentSignal.signal[frame];
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
            SignalAmplitude.Series.Add("Prog");
            SignalAmplitude.Series["Prog"].Color = Color.Red;
            SignalAmplitude.Series["Prog"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            SignalAmplitude.Series["Prog"].MarkerSize = 10;
            SignalAmplitude.Series.Add("Max");
            SignalAmplitude.Series["Max"].Color = Color.Green;
            SignalAmplitude.Series["Max"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            SignalAmplitude.Series["Max"].MarkerSize = 5;

            result = AudioHelper.PreEmFaza(result);
            result = AudioHelper.toDouble(AudioHelper.FFT(AudioHelper.toComplex(result)));

            currentSignal.amplitude = result;
            value = new double[result.Length / 2];
            freq = new double[result.Length / 2];

            for (int i = 0; i < result.Count() / 2; i++)
            {
                value[i] = AudioHelper.LinearToDecibels(result[i] / sampleRate);

                freq[i] = (int)(i * sampleRate / result.Length);           // to jest do widma amplitudowego
                SignalAmplitude.Series["Value"].Points.AddXY(freq[i], value[i]);
            }

            btnProg_Click(new object(), new EventArgs());
            SignalAmplitude.Series["Max"].Points.Clear();
            if (currentSignal.isCalculated)
            {
                foreach (PointF point in currentSignal.maksima[frame])
                {
                    SignalAmplitude.Series["Max"].Points.AddXY(point.X, point.Y);
                }
            }
            else
            {

            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numFrame_ValueChanged(object sender, EventArgs e)
        {
            RefreshSignal((int)numFrame.Value);
        }

        private void btnProg_Click(object sender, EventArgs e)
        {
           
            SignalAmplitude.Series["Prog"].Points.Clear();

            double[] freq = new double[currentSignal.amplitude.Length / 2];
            for (int i = 0; i < currentSignal.amplitude.Count() / 2; i++)
            {


                freq[i] = (int)(i * currentSignal.sampleRate / currentSignal.amplitude.Length);           // to jest do widma amplitudowego
                SignalAmplitude.Series["Prog"].Points.AddXY(freq[i], (int)numProg.Value);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sampleRate = Convert.ToDouble(currentSignal.sampleRate);
            int itr = 0;
            foreach (double[] frame in currentSignal.signal)
            {
                currentSignal.maksima.Add(new List<PointF>());
                double[] value = new double[frame.Length / 2];
                double[] freq = new double[frame.Length / 2];
                double[] result = new double[frame.Length];
                result = AudioHelper.PreEmFaza(frame);
                result = AudioHelper.toDouble(AudioHelper.FFT(AudioHelper.toComplex(result)));

                List<PointF> values = new List<PointF>();
                for (int i = 0; i < result.Count() / 2; i++)
                {
                    value[i] = AudioHelper.LinearToDecibels(result[i] / sampleRate);

                    freq[i] = (int)(i * sampleRate / result.Length);           // to jest do widma amplitudowego

                    values.Add(new PointF((float)freq[i], (float)value[i]));
                }

                // znajdujemy maksima powyżej progu:
                List<PointF> maximas = new List<PointF>();
                for (int i = 1; i < values.Count - 2; i++)
                {
                    if (values[i].Y > values[i - 1].Y && values[i].Y > values[i + 1].Y && values[i].Y > (float)numProg.Value)
                    {
                        currentSignal.maksima[itr].Add(new PointF(values[i].X, values[i].Y));
                    }
                }

                itr++;
            }




            currentSignal.isCalculated = true;
            RefreshSignal((int)numFrame.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentSignal.isCalculated = false;
            currentSignal.maksima.Clear();
            RefreshSignal((int)numFrame.Value);
        }
    }
}