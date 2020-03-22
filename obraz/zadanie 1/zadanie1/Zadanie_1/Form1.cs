using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Zadanie_1.Classes;

namespace Zadanie_1
{
    public partial class Form1 : Form
    {
        Bitmap originalImage;
        Bitmap loadedImage;

        int[,] mask;
        int[,] maskLinearFilter;


        public Form1()
        {
            InitializeComponent();
            chartLUT.Series[0].Name = "LUT";
            chartLUT.Series[0].ChartType = SeriesChartType.Spline;
            chartLUT.Series[0].BorderWidth = 2;
            chartLUT.Series[0].Color = Color.Red;

            chartLUT.ChartAreas[0].AxisX.Maximum = 255;
            chartLUT.ChartAreas[0].AxisX.Minimum = 0;
            chartLUT.ChartAreas[0].AxisY.Maximum = 255;
            chartLUT.ChartAreas[0].AxisY.Minimum = 0;
            cmbMaskSize.SelectedIndex = 0;
            cmbMaskSizeLinear.SelectedIndex = 0;
            cmbTypeLinearMask.SelectedIndex = 0;


            chartHistogram.ChartAreas[0].AxisX.Maximum = 255;
            chartHistogram.ChartAreas[0].AxisX.Minimum = 0;
            chartHistogram.ChartAreas[0].AxisY.Maximum = 255;
            chartHistogram.ChartAreas[0].AxisY.Minimum = 0;
            chartHistogram.Series.Clear();

            textBoxContrast.Text = trackBarContrast.Value.ToString();
        }

        private void Reset()
        {
            chartHistogram.Series.Clear();
            btnHistogramModify.Enabled = false;
            btnHistogramSave.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {


            if (fileDialog.ShowDialog() == DialogResult.OK)
            {

                originalImage = new Bitmap(fileDialog.FileName);
                loadedImage = originalImage.Clone() as Bitmap;
                pbImage.Image = originalImage;
                Reset();
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {

            if (pbResultImage.Image != null)
            {
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = ".jpg";
                saveFileDialog.Filter = "Obrazy(*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif|Wszystkie pliki (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbResultImage.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                }
            }


        }


        private void pbResultImage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pbResultImage.Image != null)
            {
                originalImage = new Bitmap(pbResultImage.Image);
                pbImage.Image = originalImage;
                pbResultImage.Image = null;
            }

        }

        private void btnIncreaseBrightness_Click(object sender, EventArgs e)
        {
            if (pbImage.Image != null)
            {
                Image result = ProcessingMethods.ChangeBrightness(pbImage.Image, Convert.ToInt32(brightnessValue.Value), true);
                pbResultImage.Image = result;
            }
        }

        private void btnDecreaseBrigthness_Click(object sender, EventArgs e)
        {
            if (pbImage.Image != null)
            {
                Image result = ProcessingMethods.ChangeBrightness(pbImage.Image, Convert.ToInt32(brightnessValue.Value), false);
                pbResultImage.Image = result;
            }
        }

        private void btnClearContrast_Click(object sender, EventArgs e)
        {
            trackBarContrast.Value = Math.Abs(trackBarContrast.Minimum + trackBarContrast.Maximum) / 2;
        }

        private void btnApplyContrast_Click(object sender, EventArgs e)
        {
            if (pbImage.Image != null)
            {
                byte[] LUT = new byte[256];
                chartLUT.Series[0].Points.Clear();
                //tworzenie LUT - Look Up Table
                double a;
                if (trackBarContrast.Value <= 0)
                {
                    a = 1.0 + (trackBarContrast.Value / 256.0);
                }
                else
                {
                    a = 256.0 / Math.Pow(2, Math.Log(257 - trackBarContrast.Value, 2));
                }

                for (int i = 0; i < 256; i++)
                {
                    if ((a * (i - 127) + 127) > 255)
                    {
                        LUT[i] = 255;
                    }
                    else if ((a * (i - 127) + 127) < 0)
                    {
                        LUT[i] = 0;
                    }
                    else
                    {
                        LUT[i] = (byte)(a * (i - 127) + 127);
                    }
                    chartLUT.Series[0].Points.Add(new DataPoint(i, LUT[i]));
                }

                Image result = ProcessingMethods.ChangeContrast(pbImage.Image, LUT);
                pbResultImage.Image = result;
            }

        }

        private void btnApplyNegative_Click(object sender, EventArgs e)
        {
            if (pbImage.Image != null)
            {
                Image result = ProcessingMethods.ChangeAsNegative(pbImage.Image);
                pbResultImage.Image = result;
            }
        }

        private void cmbRozmiarMaski_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMaskSize.SelectedIndex)
            {
                case 0:
                    mask = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

                    break;
                case 1:
                    mask = new int[5, 5] { { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 } };
                    break;
                case 2:
                    mask = new int[7, 7] { { 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1 } };

                    break;

            }
        }

        private void btnApplyAverageFilter_Click(object sender, EventArgs e)
        {
            if (pbImage.Image != null)
            {
                Image result = ProcessingMethods.ApplyAverageFilter(pbImage.Image, mask);
                pbResultImage.Image = result;
            }

        }

        private void btnApplyMedianFilter_Click(object sender, EventArgs e)
        {
            if (pbImage.Image != null)
            {

                Image result = ProcessingMethods.ApplyMedianFilter(pbImage.Image, mask);
                pbResultImage.Image = result;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string maskLocal = "";
            string[] lines = new string[1];

            LoadLinearMask(ref maskLocal, ref lines);
            lines = tbMaskView.Text.Split('\n');
            List<string> maskValues = new List<string>();
            foreach (string line in lines)
            {
                if (line != "" && line != "\r")
                {
                    string tmp = line.Replace("\r", "");
                    maskValues.Add(tmp.Replace("\t", ""));
                }
            }

            maskLinearFilter = new int[maskValues.Count, maskValues.Count];

            for (int i = 0; i < maskValues.Count; i++)
            {
                int index = 0;
                for (int j = 0; j < maskValues.Count; j++)
                {

                    maskLinearFilter[i, j] = GetNextValue(ref index, maskValues[i]);
                    index++;
                }
            }


            if (pbImage.Image != null)
            {

                Image result = ProcessingMethods.ApplyMask(pbImage.Image, maskLinearFilter);
                pbResultImage.Image = result;
            }




        }

        private int GetNextValue(ref int i, string stringRow)
        {
            string test = stringRow.Substring(i, 1);
            if (test == "-")
            {
                string test2 = stringRow.Substring(i, 2);
                i++;
                return Convert.ToInt32(test2);
            }
            else
            {

                return Convert.ToInt32(test);
            }
        }

        private void LoadLinearMask(ref string textMask, ref string[] textMaskLines)
        {
            string path = "Maski\\";

            switch (cmbMaskSizeLinear.SelectedIndex)
            {
                case 0:
                    path += "3x3";

                    break;
                case 1:
                    path += "5x5";

                    break;
                case 2:
                    path += "7x7";

                    break;
            }
            path += "_Liniowy_";
            switch (cmbTypeLinearMask.SelectedIndex)
            {
                case 0:
                    path += "Północ";
                    break;
                case 1:
                    path += "Północny-wschód";
                    break;
                case 2:
                    path += "Wschód";
                    break;
                case 3:
                    path += "Południowy-wschód";
                    break;
            }
            path += ".txt";

            if (File.Exists(path))
            {
                textMask = File.ReadAllText(@path);
                textMaskLines = File.ReadAllLines(@path);
            }
        }

        private void RefreshMaskLinear()
        {
            string mask = "";
            string[] lines = new string[1];
            LoadLinearMask(ref mask, ref lines);
            tbMaskView.Text = mask;
        }

        private void cmbMaskSizeLinear_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMaskLinear();
        }

        private void cmbTypeLinearMask_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMaskLinear();
        }


        private void AddSeriesToHistogram(Histogram histogram, int seriesNumber, Color color, string name)
        {
            chartHistogram.Series.Add(new Series());
            chartHistogram.Series[seriesNumber].Points.Clear();
            chartHistogram.Series[seriesNumber].Color = color;
            chartHistogram.Series[seriesNumber].ChartType = SeriesChartType.Spline;
            chartHistogram.Series[seriesNumber].BorderWidth = 2;
            chartHistogram.Series[seriesNumber].Name = name;
            for (var i = 0; i < histogram.Values.Length; i++)
            {
                chartHistogram.Series[seriesNumber].Points.Add(new DataPoint(i, histogram.Values[i]));
            }
        }


        private List<Histogram> _histograms;

        private void btnCalculateHistogram_Click(object sender, EventArgs e)
        {
            chartHistogram.Series.Clear();
            _histograms = Histogram.CreateHistogram(originalImage);
            var maxHeights = new List<int>();
            if (_histograms.Count == 1)
            {
                AddSeriesToHistogram(_histograms[0], 0, Color.Black, "Jasność");
                maxHeights.Add(_histograms[0].Values.Max());
            }

            if (_histograms.Count == 3)
            {
                AddSeriesToHistogram(_histograms[0], 0, Color.Red, "Czerwony");
                AddSeriesToHistogram(_histograms[1], 1, Color.Green, "Zielony");
                AddSeriesToHistogram(_histograms[2], 2, Color.Blue, "Niebieski");
                maxHeights.Add(_histograms[0].Values.Max());
                maxHeights.Add(_histograms[1].Values.Max());
                maxHeights.Add(_histograms[2].Values.Max());
            }

            chartHistogram.ChartAreas[0].AxisY.Maximum = maxHeights.Max();
            chartHistogram.ChartAreas[0].AxisY.LabelStyle.Format = "0";

            btnHistogramModify.Enabled = true;
            btnHistogramSave.Enabled = true;
        }

        private void trackBarContrast_ValueChanged(object sender, EventArgs e)
        {
            textBoxContrast.Text = trackBarContrast.Value.ToString();
        }

        private void btnHistogramModify_Click(object sender, EventArgs e)
        {
            var minimalBrightness = int.Parse(minimalBrightnessHistogram.Text);
            var maximalBrightness = int.Parse(maximalBrightnessHistogram.Text);
            pbResultImage.Image = ProcessingMethods.ModifyWithHistogram(pbImage.Image, _histograms, minimalBrightness, maximalBrightness);
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            pbResultImage.Image = ProcessingMethods.ApplyRosenfeld(pbImage.Image, int.Parse(valueRosenfeld.Text));
        }

        private void textBoxContrast_TextChanged(object sender, EventArgs e)
        {
            trackBarContrast.Value = int.Parse(textBoxContrast.Text);
        }

        private void btnHistogramSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".jpg";
            saveFileDialog.Filter = "Obrazy(*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif|Wszystkie pliki (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                chartHistogram.SaveImage(saveFileDialog.FileName, ImageFormat.Jpeg);
            }
        }
    }
}
