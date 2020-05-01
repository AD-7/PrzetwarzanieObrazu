using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Zadanie_1.Classes
{
    public static class FourierProcessingMethods
    {

        public static Tuple<Image,Image> ApplyFilter(Image source, Complex[,] fourierTAB, int filtr, int radius)
        {
            Bitmap result = new Bitmap(source);
            Bitmap resultMask = new Bitmap(source);
            FasterBitmap fasterBitmapResult = new FasterBitmap(result);
            FasterBitmap fasterBitmapMask = new FasterBitmap(resultMask);
            fasterBitmapResult.LockBits();
            fasterBitmapMask.LockBits();
            double[,] modulus = new double[fourierTAB.GetLength(0), fourierTAB.GetLength(1)];
         
           // fourierTAB = LowpassFilter(fourierTAB,radius);
            fourierTAB = HighpassFilter(fourierTAB, radius);
            for (int x = 0; x < fourierTAB.GetLength(0); x++)
            {
                for (int y = 0; y < fourierTAB.GetLength(1); y++)
                {
                    modulus[x, y] = Modulus(fourierTAB[x, y].Real, fourierTAB[x, y].Imaginary);

                }
            }
            modulus = Normalize(modulus, modulus.GetLength(0), modulus.GetLength(1));

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    byte color = Convert.ToByte(modulus[x, y]);
                    fasterBitmapMask.SetPixel(x, y, Color.FromArgb(color, color, color));
                }
            }


            fourierTAB = ShiftComplex(fourierTAB);
            fourierTAB = ifft2(fourierTAB);


            for (int x = 0; x < fourierTAB.GetLength(0); x++)
            {
                for (int y = 0; y < fourierTAB.GetLength(1); y++)
                {
                    modulus[x, y] = Modulus(fourierTAB[x, y].Real, fourierTAB[x, y].Imaginary);

                }
            }


            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    if(modulus[x,y] > 254 || modulus[x,y] < 0)
                    {
                        double test = modulus[x, y];
                    }
                    byte color = Convert.ToByte(modulus[x, y]);
                    fasterBitmapResult.SetPixel(x, y, Color.FromArgb(color, color, color));
                }
            }
            fasterBitmapResult.UnlockBits();
            fasterBitmapMask.UnlockBits();
            return new Tuple<Image, Image>(result,resultMask);
        }




        private static Complex[,] LowpassFilter(Complex[,] fourierTAB, int radius)
        {
            for (int x = 0; x < fourierTAB.GetLength(0); x++)
            {
                for (int y = 0; y < fourierTAB.GetLength(1); y++)
                {
                    if (Math.Sqrt(Math.Pow((x - fourierTAB.GetLength(0)/2),2) + Math.Pow((y - fourierTAB.GetLength(1)/2),2)) > radius)
                    {
                        fourierTAB[x, y] = new Complex(0, 0);
                    }

                }

            }
            return fourierTAB;
        }

        private static Complex[,] HighpassFilter(Complex[,] fourierTAB, int radius)
        {
            for (int x = 0; x < fourierTAB.GetLength(0); x++)
            {
                for (int y = 0; y < fourierTAB.GetLength(1); y++)
                {
                    if ((x == fourierTAB.GetLength(0) / 2 - 1 && y == fourierTAB.GetLength(1) / 2 - 1) ||
                        (x == fourierTAB.GetLength(0) / 2 + 1 && y == fourierTAB.GetLength(1) / 2 + 1)
                        || (x == fourierTAB.GetLength(0) / 2 + 1 && y == fourierTAB.GetLength(1) / 2 - 1)
                        || (x == fourierTAB.GetLength(0) / 2 - 1 && y == fourierTAB.GetLength(1) / 2 + 1)
                        || (x == fourierTAB.GetLength(0) / 2  && y == fourierTAB.GetLength(1) / 2 ))
                    {

                    }
                    else
                    if (Math.Sqrt(Math.Pow((x - fourierTAB.GetLength(0) / 2), 2) + Math.Pow((y - fourierTAB.GetLength(1) / 2), 2)) <= radius)
                    {
                        fourierTAB[x, y] = new Complex(0, 0);
                    }

                }

            }
            return fourierTAB;
        }


        public static Tuple<Image,Image,Complex[,]> CalculateFFT(Image source)
        {
            Bitmap resultAmplitude = new Bitmap(source);
            Bitmap result = new Bitmap(source);
            FasterBitmap fasterBitmapSrc = new FasterBitmap(source as Bitmap);
            FasterBitmap fasterBitmapAmplitude = new FasterBitmap(resultAmplitude);
            FasterBitmap fasterBitmapResult = new FasterBitmap(result);

            fasterBitmapAmplitude.LockBits();
            fasterBitmapSrc.LockBits();
            fasterBitmapResult.LockBits();

            Complex[,] original = new Complex[source.Width, source.Height];

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    original[x, y] = fasterBitmapSrc.GetPixel(x, y).R;

                }
            }

            Complex[,] fourier = fft2(original);
            fourier = ShiftComplex(fourier);
            double[,] modulus = new double[fourier.GetLength(0), fourier.GetLength(1)];

            for (int x = 0; x < fourier.GetLength(0); x++)
            {
                for (int y = 0; y < fourier.GetLength(1); y++)
                {
                    modulus[x, y] = Modulus(fourier[x, y].Real, fourier[x, y].Imaginary);

                }
            }

            double[,] amplitude = Normalize(modulus, source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    byte color = Convert.ToByte(amplitude[x, y]);
                    fasterBitmapAmplitude.SetPixel(x, y, Color.FromArgb(color, color, color));
                }
            }



            Complex[,] fourierTAB = new Complex[fourier.GetLength(0),fourier.GetLength(1)];
            fourierTAB = fourier;

            //fourier = ShiftComplex(fourier);

            //fourier = ifft2(fourier);


            //for (int x = 0; x < fourier.GetLength(0); x++)
            //{
            //    for (int y = 0; y < fourier.GetLength(1); y++)
            //    {
            //        modulus[x, y] = Modulus(fourier[x, y].Real, fourier[x, y].Imaginary);

            //    }
            //}


            //for (int x = 0; x < source.Width; x++)
            //{
            //    for (int y = 0; y < source.Height; y++)
            //    {
            //        byte color = Convert.ToByte(modulus[x, y]);
            //        fasterBitmapResult.SetPixel(x, y, Color.FromArgb(color, color, color));
            //    }
            //}


            fasterBitmapAmplitude.UnlockBits();
            fasterBitmapSrc.UnlockBits();
            fasterBitmapResult.UnlockBits();
            return new Tuple<Image, Image,Complex[,]>(resultAmplitude,null,fourierTAB);
        }


       



        public static Complex[,] fft2(Complex[,] a)
        {
            int w = a.GetLength(0);
            int h = a.GetLength(1);

            Complex[,] result = new Complex[w, h];

            for (int y = 0; y < h; y++)
            {
                Complex[] row = new Complex[w];

                for (int x = 0; x < w; x++)
                    row[x] = a[x, y];

                Complex[] frow = fft(row);

                for (int x = 0; x < w; x++)
                    result[x, y] = frow[x];
            }

            for (int x = 0; x < w; x++)
            {
                Complex[] col = new Complex[h];

                for (int y = 0; y < h; y++)
                    col[y] = result[x, y];

                Complex[] fcol = fft(col);

                for (int y = 0; y < h; y++)
                    result[x, y] = fcol[y];
            }

            return result;
        }


        public static Complex[] fft(Complex[] a_ar, int a_length = -1)
        {
            if (a_length == -1)
                a_length = a_ar.Length;

            Complex[] result = new Complex[a_length];

            for (int k = 0; k < result.Length; k++)
            {

                for (int n = 0; n < a_ar.Length; n++)
                {
                    double phase = -2 * Math.PI * k * n / a_ar.Length;
                    result[k] += a_ar[n] * new Complex(Math.Cos(phase), Math.Sin(phase));
                }
            }

            return result;
        }
        public static Complex[,] ifft2(Complex[,] a)
        {
            int w = a.GetLength(0);
            int h = a.GetLength(1);

            Complex[,] result = new Complex[w, h];

            for (int y = 0; y < h; y++)
            {
                Complex[] row = new Complex[w];

                for (int x = 0; x < w; x++)
                    row[x] = a[x, y];

                Complex[] frow = ifft(row);

                for (int x = 0; x < w; x++)
                    result[x, y] = frow[x] / w;
            }

            for (int x = 0; x < w; x++)
            {
                Complex[] col = new Complex[h];

                for (int y = 0; y < h; y++)
                    col[y] = result[x, y];

                Complex[] fcol = ifft(col);

                for (int y = 0; y < h; y++)
                    result[x, y] = fcol[y] / h;
            }

            return result;
        }
        public static Complex[] ifft(Complex[] a_ar, int a_length = -1)
        {
            if (a_length == -1)
                a_length = a_ar.Length;

            Complex[] result = new Complex[a_length];

            for (int k = 0; k < result.Length; k++)
            {

                for (int n = 0; n < a_ar.Length; n++)
                {
                    double phase = 2 * Math.PI * k * n / a_ar.Length;
                    result[k] += a_ar[n] * new Complex(Math.Cos(phase), Math.Sin(phase));
                }
            
            }
            
            return result;
        }



        private static double Modulus(double real, double imaginary)
        {
            return Math.Sqrt((real * real) + (imaginary * imaginary));
        }

        private static double FindMax(double[,] tab)
        {
            double max = tab[0, 0];

            foreach (double value in tab)
            {
                if (max < value)
                {
                    max = value;
                }
            }

            return max;
        }


        private static double[,] Normalize(double[,] tab, int width, int height)
        {
            double max = FindMax(tab);
            double[,] result = new double[width, height];
            for (int u = 0; u < width; u++)
            {
                for (int v = 0; v < height; v++)
                {
                    result[u, v] = (Math.Log10(1 + tab[u, v]) * 255) / (Math.Log10(1 + max));
                }
            }

            return result;
        }

        private static double[,] Shift(double[,] tab)
        {
            double[,] result = new double[tab.GetLength(0), tab.GetLength(1)];


            int i = 0, j = 0;
            for (int x = 0; x < tab.GetLength(0) / 2; x++)
            {
                j = 0;
                for (int y = 0; y < tab.GetLength(1) / 2; y++)
                {

                    result[x + tab.GetLength(0) / 2, y + tab.GetLength(1) / 2] = tab[x, y]; //lewo_gora
                    j++;
                }
                i++;
            }

            i = 0;
            for (int x = tab.GetLength(0) / 2; x < tab.GetLength(0); x++)
            {
                j = 0;
                for (int y = 0; y < tab.GetLength(1) / 2; y++)
                {
                    result[x - tab.GetLength(0) / 2, y + tab.GetLength(1) / 2] = tab[x, y];  //prawo_gora
                    j++;
                }
                i++;
            }

            i = 0;
            for (int x = tab.GetLength(0) / 2; x < tab.GetLength(0); x++)
            {
                j = 0;
                for (int y = tab.GetLength(1) / 2; y < tab.GetLength(1); y++)
                {
                    result[x - tab.GetLength(0) / 2, y - tab.GetLength(1) / 2] = tab[x, y];    //prawo_dol
                    j++;
                }
                i++;
            }

            i = 0;
            for (int x = 0; x < tab.GetLength(0) / 2; x++)
            {
                j = 0;
                for (int y = tab.GetLength(1) / 2; y < tab.GetLength(1); y++)
                {
                    result[x + tab.GetLength(0) / 2, y - tab.GetLength(1) / 2] = tab[x, y];    //lewo_dol
                    j++;
                }
                i++;
            }







            return result;



        }

        private static Complex[,] ShiftComplex(Complex[,] tab)
        {
            Complex[,] result = new Complex[tab.GetLength(0), tab.GetLength(1)];


            int i = 0, j = 0;
            for (int x = 0; x < tab.GetLength(0) / 2; x++)
            {
                j = 0;
                for (int y = 0; y < tab.GetLength(1) / 2; y++)
                {

                    result[x + tab.GetLength(0) / 2, y + tab.GetLength(1) / 2] = tab[x, y]; //lewo_gora
                    j++;
                }
                i++;
            }

            i = 0;
            for (int x = tab.GetLength(0) / 2; x < tab.GetLength(0); x++)
            {
                j = 0;
                for (int y = 0; y < tab.GetLength(1) / 2; y++)
                {
                    result[x - tab.GetLength(0) / 2, y + tab.GetLength(1) / 2] = tab[x, y];  //prawo_gora
                    j++;
                }
                i++;
            }

            i = 0;
            for (int x = tab.GetLength(0) / 2; x < tab.GetLength(0); x++)
            {
                j = 0;
                for (int y = tab.GetLength(1) / 2; y < tab.GetLength(1); y++)
                {
                    result[x - tab.GetLength(0) / 2, y - tab.GetLength(1) / 2] = tab[x, y];    //prawo_dol
                    j++;
                }
                i++;
            }

            i = 0;
            for (int x = 0; x < tab.GetLength(0) / 2; x++)
            {
                j = 0;
                for (int y = tab.GetLength(1) / 2; y < tab.GetLength(1); y++)
                {
                    result[x + tab.GetLength(0) / 2, y - tab.GetLength(1) / 2] = tab[x, y];    //lewo_dol
                    j++;
                }
                i++;
            }







            return result;



        }

    }
}
