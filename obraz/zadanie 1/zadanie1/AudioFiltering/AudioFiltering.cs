﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioFiltering
{
    public partial class AudioFiltering : Form
    {
        Parameters parameters;
        public AudioFiltering()
        {
            InitializeComponent();
             parameters = new Parameters();
       
        }
        float[] _loadedSignal;
        float[] _filteredSignal;
        int _frameSize = 1024;
        float _frameHopSize = 511;
        bool _ifCausal = true;
        int _filterSize = 921;
        float _filterCutOff = 433;
        WindowType _windowType = WindowType.Hamming;
        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {


            float[] result = Helper.Load_wav_File(Audio.Classes.Path.GetSoundPath());
            _loadedSignal = result;
            chartSignal.Series.Clear();
            chartSignal.Series.Add("Value");
            chartSignal.Series["Value"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartSignal.Series["Value"].MarkerSize = 1;

            for (int i = 0; i < result.Count(); i++)
            {
                float value = result[i] / 44100.0f;
                float time = i / 44100.0f;
                //   freq[i] = (int)(i * sampleRate / result.Length);           // to jest do widma amplitudowego
                chartSignal.Series["Value"].Points.AddXY(time, value);
            }


        }

        private void parametryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            parameters.ShowDialog();

            _frameHopSize = parameters._frameHopSize;
            _filterSize = parameters._filterSize;
            _frameSize = parameters._frameSize;
            _filterCutOff = parameters._filterCutOff;
            _ifCausal = parameters._ifCausal;
            _windowType = (WindowType)parameters._WindowType;
       

        }

        private void pokażWykresFiltruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float[] filter = Helper.CreateImpulseSignal(_filterSize, _filterCutOff, 44100,_windowType,_ifCausal);

            FilterCHart chart = new FilterCHart(filter);
            chart.Show();
        }

        private void dziedzinaCzasuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_loadedSignal == null)
                return;
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now;
            float[] resultTime = Helper.SignalFilterTime(_loadedSignal, _frameSize, (int)_frameHopSize, Helper.CreateImpulseSignal(_filterSize, _filterCutOff, 44100, _windowType, _ifCausal));
            _filteredSignal = resultTime;
            chartFiltered.Series.Clear();
            chartFiltered.Series.Add("Value");
            chartFiltered.Series["Value"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartFiltered.Series["Value"].MarkerSize = 1;

            for (int i = 0; i < resultTime.Count(); i++)
            {
                float value = resultTime[i] / 44100.0f;
                float time = i / 44100.0f;
                //   freq[i] = (int)(i * sampleRate / result.Length);           // to jest do widma amplitudowego
                chartFiltered.Series["Value"].Points.AddXY(time, value);
            }
            end = DateTime.Now;
            TimeSpan timespan = end - start;
            tbTime.Text = " " + timespan.TotalSeconds.ToString() + " s";


        }

        private void dziedzinaCzęstotliwościToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_loadedSignal == null)
                return;
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now;
            float[] resultFreq = Helper.SignalFilterFreq(_loadedSignal, _frameSize, (int)_frameHopSize,_filterSize,_filterCutOff, _windowType, _ifCausal);
            _filteredSignal = resultFreq;
            chartFiltered.Series.Clear();
            chartFiltered.Series.Add("Value");
            chartFiltered.Series["Value"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartFiltered.Series["Value"].MarkerSize = 1;

            for (int i = 0; i < resultFreq.Count(); i++)
            {
                float value = resultFreq[i] / 44100.0f;
                float time = i / 44100.0f;
                //   freq[i] = (int)(i * sampleRate / result.Length);           // to jest do widma amplitudowego
                chartFiltered.Series["Value"].Points.AddXY(time, value);
            }
            end = DateTime.Now;
            TimeSpan timespan = end - start;
            tbTime.Text = " " + timespan.TotalSeconds.ToString() + " s";
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetFileName getfilename = new GetFileName();
            getfilename.ShowDialog();

            Helper.WriteSound(_filteredSignal, getfilename.fileName);
            getfilename.Dispose();
        }
    }
}
