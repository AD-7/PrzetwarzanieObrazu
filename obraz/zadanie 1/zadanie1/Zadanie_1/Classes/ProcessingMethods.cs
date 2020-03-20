using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1.Classes
{
    public static class ProcessingMethods
    {

        public static Bitmap ChangeBrightness(Image image, int value, bool ifIncrease) // ifIncrease = true -> zwiększ jasność, ifInrease= false zmniejsz
        {
            Bitmap result = new Bitmap(image);
            FasterBitmap fasterBitmap = new FasterBitmap(result);
            fasterBitmap.LockBits();

            for (int y = 0; y < fasterBitmap.Height; y++)
            {
                for (int x = 0; x < fasterBitmap.Width; x++)
                {
                    Color pixel = fasterBitmap.GetPixel(x, y);
                    int R = pixel.R;
                    int G = pixel.G;
                    int B = pixel.B;
                    if (ifIncrease)
                    {
                        if (R + value <= 255)
                        {
                            R = Convert.ToByte(R + value);
                        }
                        else
                        {
                            R = 255;
                        }
                        if (G + value <= 255)
                        {
                            G = Convert.ToByte(G + value);
                        }
                        else
                        {
                            G = 255;
                        }
                        if (B + value <= 255)
                        {
                            B = Convert.ToByte(B + value);
                        }
                        else
                        {
                            B = 255;
                        }
                    }
                    else
                    {
                        if (R - value >= 0)
                        {
                            R = Convert.ToByte(R - value);
                        }
                        else
                        {
                            R = 0;
                        }
                        if (G - value >= 0)
                        {
                            G = Convert.ToByte(G - value);
                        }
                        else
                        {
                            G = 0;
                        }
                        if (B - value >= 0)
                        {
                            B = Convert.ToByte(B - value);
                        }
                        else
                        {
                            B = 0;
                        }
                    }
                    Color newPixel = Color.FromArgb(R, G, B);

                    fasterBitmap.SetPixel(x, y, newPixel);
                }
            }

            fasterBitmap.UnlockBits();
            return result;
        }


        public static Bitmap ChangeContrast(Image image, byte[] LUT)
        {
            Bitmap result = new Bitmap(image);
            FasterBitmap fasterBitmap = new FasterBitmap(result);
            fasterBitmap.LockBits();

            for (int y = 0; y < fasterBitmap.Height; y++)
            {
                for (int x = 0; x < fasterBitmap.Width; x++)
                {
                    Color pixel = fasterBitmap.GetPixel(x, y);
                    int R = LUT[pixel.R];
                    int G = LUT[pixel.G];
                    int B = LUT[pixel.B];
                    fasterBitmap.SetPixel(x, y, Color.FromArgb(R, G, B));

                }
            }
            fasterBitmap.UnlockBits();

            return result;
        }


        public static Bitmap ChangeAsNegative(Image image)
        {
            Bitmap result = new Bitmap(image);
            FasterBitmap fasterBitmap = new FasterBitmap(result);




            fasterBitmap.LockBits();
            // LUT
            byte[] LUT = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                LUT[i] = Convert.ToByte(255 - i);
            }
            //negatyw z LUT
            for (int y = 0; y < fasterBitmap.Height; y++)
            {
                for (int x = 0; x < fasterBitmap.Width; x++)
                {
                    Color pixel = fasterBitmap.GetPixel(x, y);
                    int R = LUT[pixel.R];
                    int G = LUT[pixel.G];
                    int B = LUT[pixel.B];
                    fasterBitmap.SetPixel(x, y, Color.FromArgb(R, G, B));

                }
            }

            fasterBitmap.UnlockBits();
            return result;
        }

        public static Bitmap ApplyMask(Image image, int[,] mask)
        {
            Bitmap result = new Bitmap(image);
            Bitmap tmp = new Bitmap(image);
            FasterBitmap fasterBitmap = new FasterBitmap(result);
            FasterBitmap bitmapHelperValues = new FasterBitmap(tmp);


            int len = mask.Length;
            int width = Convert.ToInt32(Math.Sqrt(len));
            int ignorePixels = 0;
            int divide = 0;

            foreach (int maskVlaue in mask)
            {
                divide += maskVlaue;
            }

            if (len == 9)
            {
                ignorePixels = 1;
            }
            else if (len == 25)
            {
                ignorePixels = 2;
            }
            else if (len == 49)
            {
                ignorePixels = 3;
            }




            fasterBitmap.LockBits();
            bitmapHelperValues.LockBits();

            for (int x = ignorePixels; x < image.Width - ignorePixels - 1; x++)
            {
                for (int y = ignorePixels; y < image.Height - ignorePixels - 1; y++)
                {
                    int sumR = 0;
                    int sumG = 0;
                    int sumB = 0;

                    for (int i = -ignorePixels; i <= ignorePixels; i++)
                    {
                        for (int j = -ignorePixels; j <= ignorePixels; j++)
                        {
                            sumR += bitmapHelperValues.GetPixel(x + i, y + j).R * mask[i + ignorePixels, j + ignorePixels];
                            sumG += bitmapHelperValues.GetPixel(x + i, y + j).G * mask[i + ignorePixels, j + ignorePixels];
                            sumB += bitmapHelperValues.GetPixel(x + i, y + j).B * mask[i + ignorePixels, j + ignorePixels];

                        }

                    }

                    int avgR;
                    int avgG;
                    int avgB;
                    if (!(divide <= 0))
                    {
                        avgR = sumR / (divide);
                        avgG = sumG / (divide);
                        avgB = sumB / (divide);
                    }

                    if (sumR < 0)
                    {
                        avgR = 0;
                    }
                    else if (sumR > 255)
                    {
                        avgR = 255;
                    }
                    else
                    {
                        avgR = sumR;
                    }
                    if (sumG < 0)
                    {
                        avgG = 0;
                    }
                    else if (sumG > 255)
                    {
                        avgG = 255;
                    }
                    else
                    {
                        avgG = sumG;
                    }
                    if (sumB < 0)
                    {
                        avgB = 0;
                    }
                    else if (sumB > 255)
                    {
                        avgB = 255;
                    }
                    else
                    {
                        avgB = sumB;
                    }



                    Color avgColor = Color.FromArgb(avgR, avgG, avgB);
                    fasterBitmap.SetPixel(x, y, avgColor);

                }
            }

            fasterBitmap.UnlockBits();
            bitmapHelperValues.UnlockBits();
            return result;
        }

        public static Bitmap ApplyAverageFilter(Image image, int[,] mask)
        {
            return ApplyMask(image, mask);

        }



        public static Bitmap ApplyMedianFilter(Image image, int[,] mask)
        {
            Bitmap result = new Bitmap(image);
            Bitmap tmp = new Bitmap(image);
            FasterBitmap fasterBitmap = new FasterBitmap(result);
            FasterBitmap bitmapHelperValues = new FasterBitmap(tmp);
            int len = mask.Length;
            int width = Convert.ToInt32(Math.Sqrt(len));
            int ignorePixels = 0;
            if (len == 9)
            {
                ignorePixels = 1;
            }
            else if (len == 25)
            {
                ignorePixels = 2;
            }
            else if (len == 49)
            {
                ignorePixels = 3;
            }

            List<int> valuesR = new List<int>();
            List<int> valuesG = new List<int>();
            List<int> valuesB = new List<int>();


            fasterBitmap.LockBits();
            bitmapHelperValues.LockBits();
            for (int x = ignorePixels; x < image.Width - ignorePixels; x++)
            {
                for (int y = ignorePixels; y < image.Height - ignorePixels; y++)
                {
                    valuesR.Clear();
                    valuesG.Clear();
                    valuesB.Clear();
                    for (int i = -ignorePixels; i <= ignorePixels; i++)
                    {
                        for (int j = -ignorePixels; j <= ignorePixels; j++)
                        {
                            valuesR.Add(bitmapHelperValues.GetPixel(x + i, y + j).R);
                            valuesG.Add(bitmapHelperValues.GetPixel(x + i, y + j).G);
                            valuesB.Add(bitmapHelperValues.GetPixel(x + i, y + j).B);

                        }
                    }

                    valuesR.Sort();
                    valuesG.Sort();
                    valuesB.Sort();

                    int medianR = valuesR[(len - 1) / 2];
                    int medianG = valuesG[(len - 1) / 2];
                    int medianB = valuesB[(len - 1) / 2];
                    Color medianColor = Color.FromArgb(medianR, medianG, medianB);
                    fasterBitmap.SetPixel(x, y, medianColor);

                }
            }


            fasterBitmap.UnlockBits();
            bitmapHelperValues.UnlockBits();
            return result;

        }



        public static Bitmap ModifyWithHistogram(Image image, List<Histogram> histograms, int minimalBrightness, int maximalBrightness)
        {
            var minimalPower = Math.Pow(minimalBrightness, 1.0 / 3);
            var maximalPower = Math.Pow(maximalBrightness, 1.0 / 3);
            var test = Image.GetPixelFormatSize(image.PixelFormat) != 8;
            var result = new Bitmap(image);
            var fasterBitmap = new FasterBitmap(result);
            fasterBitmap.LockBits();
            var pixelNumber = (double)fasterBitmap.Width * fasterBitmap.Height;

            int Calculate(int value, Histogram histogram)
            {
                var sum = histogram.CalculateSum(value);
                var calculated = Math.Pow((minimalPower + (maximalPower - minimalPower) * (sum / pixelNumber)), 3.0);
                if (calculated < 0) return 0;
                if (calculated > 255) return 255;
                return (int)calculated;
            }


            for (int i = 0; i < fasterBitmap.Height; i++)
            {
                for (int j = 0; j < fasterBitmap.Width; j++)
                {
                    var color = fasterBitmap.GetPixel(i, j);
                    var r = Calculate(color.R, histograms[0]);
                    var g = r;
                    var b = r;
                    if (test)
                    {
                        g = Calculate(color.G, histograms[1]);
                        b = Calculate(color.B, histograms[2]);
                    }
                    fasterBitmap.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            fasterBitmap.UnlockBits();
            return result;
        }

        private static int ProcessSingleColor(FasterBitmap fasterBitmap, int x, int y, int channel, double rCoefficient)
        {
            int sum1 = 0, sum2 = 0;
            for (var i = 1; i < rCoefficient; i++)
            {
                if (x + i - 1 < 0 || x + i > fasterBitmap.Width)
                {
                    continue;
                }

                sum1 += fasterBitmap.GetSingleChannel(x + i - 1, y, channel);
            }
            for (var i = 1; i < rCoefficient; i++)
            {
                if (x - 1 < 0 || x - 1 > fasterBitmap.Width)
                {
                    continue;
                }
                sum2 += fasterBitmap.GetSingleChannel(x - 1, y, channel);
            }
            var result = (int)((sum1 - sum2) / rCoefficient);
            if (result > 255)
            {
                return 255;
            }
            if (result < 0)
            {
                return 0;
            }
            return result;
        }


        public static Bitmap ApplyRosenfeld(Image image, double p)
        {
            var original = new Bitmap(image);
            var originalBitmap = new FasterBitmap(original);
            var result = new Bitmap(image);
            var resultBitmap = new FasterBitmap(result);
            var test = Image.GetPixelFormatSize(image.PixelFormat) == 8;
            resultBitmap.LockBits();
            originalBitmap.LockBits();

            for (var i = 0; i < resultBitmap.Height; i++)
            {
                for (var j = 0; j < resultBitmap.Width; j++)
                {
                    if (test)
                    {
                        var value = ProcessSingleColor(originalBitmap, i, j, 0, p);
                        resultBitmap.SetPixel(i, j, Color.FromArgb(value, value, value));
                    }
                    else
                    {
                        var r = ProcessSingleColor(originalBitmap, i, j, 0, p);
                        var g = ProcessSingleColor(originalBitmap, i, j, 1, p);
                        var b = ProcessSingleColor(originalBitmap, i, j, 2, p);
                        resultBitmap.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }
            }

            resultBitmap.UnlockBits();
            originalBitmap.UnlockBits();
            return result;
        }


    }
}