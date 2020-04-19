﻿using System;
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
        public static Image CalculateDFT(Image source)
        {
            Bitmap result = new Bitmap(source);
            FasterBitmap fasterBitmapSrc = new FasterBitmap(source as Bitmap);
            FasterBitmap fasterBitmap = new FasterBitmap(result);
            fasterBitmap.LockBits();
            fasterBitmapSrc.LockBits();

            Complex[,] original = new Complex[source.Width, source.Height];

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    original[x, y] = fasterBitmapSrc.GetPixel(x, y).R;

                }
            }

            Complex[,] fourier = fft2(original);
            double[,] modulus = new double[fourier.GetLength(0), fourier.GetLength(1)];

            for (int x = 0; x < fourier.GetLength(0); x++)
            {
                for (int y = 0; y < fourier.GetLength(1); y++)
                {
                    modulus[x, y] = Modulus(fourier[x, y].Real, fourier[x, y].Imaginary);

                }
            }
            modulus = Normalize(modulus, source.Width, source.Height);

            modulus = Shift(modulus);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    byte color = Convert.ToByte(modulus[x, y]);
                    fasterBitmap.SetPixel(x, y, Color.FromArgb(color, color, color));
                }
            }

      

            fasterBitmap.UnlockBits();
            fasterBitmapSrc.UnlockBits();
            return result;
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


    }
}
