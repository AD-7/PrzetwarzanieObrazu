using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace Audio.Classes
{


    public class AudioHelper
    {
        int sampleRate = 0;


        public Tuple<List<double[]>, int, TimeSpan> openWav(string filename, out short[] sampleBuffer, int WindowSize)
        {

            if (File.Exists(filename))
            {



                TimeSpan time = new TimeSpan();
                using (WaveFileReader reader = new WaveFileReader(filename))
                {
                    sampleRate = reader.WaveFormat.SampleRate;
                    time = reader.TotalTime;

                    byte[] buffer = new byte[reader.Length];
                    int read = reader.Read(buffer, 0, buffer.Length);
                    sampleBuffer = new short[read / 2];
                    Buffer.BlockCopy(buffer, 0, sampleBuffer, 0, read);

                }


                List<double[]> result = new List<double[]>();
                result.Add(new double[WindowSize]);
                int i = 0;
                int j = 0;
                int r = 0;
                foreach (short tmp in sampleBuffer)
                {

                    result[r][i] = sampleBuffer[j];
                    i++;
                    j++;
                    if (i == WindowSize)
                    {
                        i = 0;
                        r++;
                        result.Add(new double[WindowSize]);
                    }

                }
                result.RemoveAt(result.Count - 1);
                //  result = TriangleWindow(result);
                //Complex[] resultComplex = new Complex[result.Length];
                //for (int z = 0; z < result.Length; z++)
                //{
                //    resultComplex[z] = result[z];
                //}

                //resultComplex = FFT(resultComplex);
                //for (int z = 0; z < result.Length; z++)
                //{
                //    result[z] = 2 * Modulus(resultComplex[z].Real, resultComplex[z].Imaginary) / result.Length;
                //}

                return new Tuple<List<double[]>, int, TimeSpan>(result, sampleRate, time);
            }
            else
            {
                sampleBuffer = new short[1];
                return null;
            }
        }


        public double[] TriangleWindow(double[] data)
        {
            double[] result = new double[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                result[i] = data[i] * (1 - (i * 1.0) / data.Length);
            }
            return result;
        }

        public double[] HammingWindow(double[] data)
        {
            double[] result = new double[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                result[i] = 0.53836 - 0.46164 * Math.Cos((2 * Math.PI * i) / (data.Length - 1));
            }
            return result;
        }

        public static double[] PreEmFaza(double[] data)
        {
            double[] result = new double[data.Length];
            for (int i = 1; i < data.Length; i++)
            {
                result[i] = data[i] - 0.9 * data[i - 1];
            }
            return result;
        }
        public static int BitReverse(int n, int bits)
        {
            int reversedN = n;
            int count = bits - 1;

            n >>= 1;
            while (n > 0)
            {
                reversedN = (reversedN << 1) | (n & 1);
                count--;
                n >>= 1;
            }

            return ((reversedN << count) & ((1 << bits) - 1));
        }

        public static Complex[] FFT(Complex[] buffer, bool forward)
        {

            int bits = (int)Math.Log(buffer.Length, 2);
            for (int j = 1; j < buffer.Length; j++)
            {
                int swapPos = BitReverse(j, bits);
                if (swapPos <= j)
                {
                    continue;
                }
                var temp = buffer[j];
                buffer[j] = buffer[swapPos];
                buffer[swapPos] = temp;
            }




            for (int N = 2; N <= buffer.Length; N <<= 1)
            {
                for (int i = 0; i < buffer.Length; i += N)
                {
                    for (int k = 0; k < N / 2; k++)
                    {

                        int evenIndex = i + k;
                        int oddIndex = i + k + (N / 2);


                        Complex even = 0.0;

                        Complex odd = 0.0;

                        if (oddIndex < buffer.Length)
                        {
                            odd = buffer[oddIndex];
                        }
                        if (evenIndex < buffer.Length)
                        {
                            even = buffer[evenIndex];
                        }
                        double term = 0;
                        if (forward)
                            term = -2 * Math.PI * k / (double)N;
                        else
                            term = 2 * Math.PI * k / (double)N;

                        Complex exp = new Complex(Math.Cos(term), Math.Sin(term)) * odd;
                        if (evenIndex < buffer.Length)
                        {
                            buffer[evenIndex] = even + exp;
                        }
                        if (oddIndex < buffer.Length)
                        {
                            buffer[oddIndex] = even - exp;
                        }
                    }
                }
            }

            return buffer;
        }
        private static double Modulus(double real, double imaginary)
        {
            return Math.Sqrt((real * real) + (imaginary * imaginary));
        }

        public static Complex[] toComplex(double[] data)
        {
            Complex[] resultComplex = new Complex[data.Length];
            for (int z = 0; z < data.Length; z++)
            {
                resultComplex[z] = data[z];
            }

            return resultComplex;
        }

        public static double[] toDouble(Complex[] data)
        {
            double[] result = new double[data.Length];
            for (int z = 0; z < result.Length; z++)
            {
                result[z] = 2 * Modulus(data[z].Real, data[z].Imaginary) / result.Length;
            }
            return result;
        }
        private const double LOG_2_DB = 8.6858896380650365530225783783321;
        private const double DB_2_LOG = 0.11512925464970228420089957273422;

        public static double LinearToDecibels(double lin)
        {
            return Math.Log10(lin) * 10;// * LOG_2_DB;
        }
    }
}
