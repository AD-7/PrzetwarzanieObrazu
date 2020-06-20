
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AudioFiltering
{
    public class Helper
    {

        public static float[] Load_wav_File(string file)
        {
            AudioFileReader audio = new AudioFileReader(file);
            int Length = (int)(audio.Length / sizeof(float));
            float[] result = new float[Length];
            audio.Read(result, 0, Length);
            return result;
        }
        public static float[] AddLZeros(float[] data, int L)
        {
            float[] zeros = new float[L - 1];

            List<float> result = new List<float>(zeros);
            result.AddRange(data);
            result.AddRange(zeros);

            return result.ToArray();
        }

        public static float[] AddZerosAfter(float[] data, int zerosCount)
        {
            float[] zeros = new float[zerosCount];

            List<float> result = new List<float>(data);
            result.AddRange(zeros);

            return result.ToArray();
        }

        public static float[] AddZerosInMiddle(float[] data, int zerosCount)
        {
            float[] zeros = new float[zerosCount];

            List<float> result = new List<float>(data.Take(data.Length / 2));
            result.AddRange(zeros);
            result.AddRange(data.Skip(data.Length / 2));

            return result.ToArray();
        }

        public static float[] CreateImpulseSignal(int size, float cutOffFrequency, int sampleRate)
        {
            if (size % 2 == 0)
                throw new Exception("Rozmiar filtra powinien być nieparzysty.");
            float[] result = new float[size];
            float twoFcOverFs = (2f * cutOffFrequency) / sampleRate;
            int halfSize = (size - 1) / 2;
            for (int k = 0; k < size; k++)
            {
                if (k == halfSize)
                    result[k] = twoFcOverFs;
                else
                    result[k] = (float)(Math.Sin(Math.PI * twoFcOverFs * (k - halfSize)) / (Math.PI * (k - halfSize)));
            }

            return result;
        }

        public static float[] CreateImpulseSignal(int size, float cutOffFrequency, int sampleRate, WindowType windowType, bool causal)
        {
            return SignalWindow.MultiplyByWindow(CreateImpulseSignal(size, cutOffFrequency, sampleRate), causal, windowType);
        }

        public static float[][] CreateFrames(float[] signal, int frameSize, int frameOffSet)
        {
            int framesCount = (signal.Length - frameSize) / frameOffSet;
            float[][] result = new float[framesCount][];
            for (int i = 0; i < framesCount; i++)
            {
                result[i] = signal.Skip(i * frameOffSet).Take(frameSize).ToArray();
            }

            return result;
        }

        public static float[] FilterPerFrameTime(float[] ignal, float[] filter)
        {
            float[] dataWithZeros = AddLZeros(ignal, filter.Length);
            float[] result = new float[dataWithZeros.Length - filter.Length - 1];
            for (int n = 0; n < result.Length; n++)
                result[n] = filter.Select((f, k) => dataWithZeros[filter.Length + n - k - 1] * f).Sum();
            return result;
        }

        public static float[] FilterPerFrameFreq(float[] frame, Complex[] filterAfterFFT)
        {
            Complex[] dataFFT = frame.Select(v => new Complex(v, 0)).ToArray();
            dataFFT = Audio.Classes.AudioHelper.FFT(dataFFT, true);
            Complex[] result = new Complex[frame.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = dataFFT[i] * filterAfterFFT[i];
            }

            result = Audio.Classes.AudioHelper.FFT(result, false);

            float[] resultF = result.Select(r => (float)r.Real).ToArray();

            return resultF;
        }


        public static float[] SignalFilterTime(float[] signal, int frameSize, int frameOffset, float[] filter)
        {
            float[][] frames = CreateFrames(signal, frameSize, frameOffset);
            float[] result = new float[signal.Length + filter.Length];
            for (int i = 0; i < frames.Length; i++)
            {
                float[] filtered = FilterPerFrameTime(frames[i], filter);
                for (int j = 0; j < filtered.Length; j++)
                {
                    result[i * frameOffset + j] += filtered[j];
                }
            }
            return result;
        }





        public static float[] SignalFilterFreq(float[] signal, int frameSize, int frameOffset,
             int filterSize, float filterCutoff, WindowType windowType, bool causal)
        {

            float[] impulse = Helper.CreateImpulseSignal(filterSize, filterCutoff, 44100);

            int powerTwo = 0;

            for (int p = 2; p <= 120000; p *= 2)
            {
                if (p >= frameSize + impulse.Length - 1)
                {
                    powerTwo = p;
                    break;
                }
            }
            float[] filter = new float[powerTwo];
            if (causal)
            {
                filter = Helper.AddZerosAfter(impulse, powerTwo - impulse.Length);
            }
            else
            {
                filter = Helper.AddZerosInMiddle(impulse, powerTwo - impulse.Length);
            }



            float[][] frames = CreateFrames(signal, frameSize, frameOffset);
            float[] result = new float[signal.Length + filter.Length - frameSize];
            Complex[] fftFilter = filter.Select(v => new Complex(v, 0)).ToArray();


           fftFilter =  Audio.Classes.AudioHelper.FFT(fftFilter, true);


            float[] windowValues = SignalWindow.ValuesByWindow(frameSize, true,windowType);


            for (int i = 0; i < frames.Length; i++)
            {
                float[] frame = new float[frameSize];

                for(int j=0; j < frame.Length; j++)
                {
                    frame[j] = frames[i][j] * windowValues[j];    // każda ramka wymnożona przez wartości okna
                }

                float[] frameWithZeros = AddZerosAfter(frame, filter.Length - frames[i].Length); // uzupełniamy zerami na końcu ramki

                float[] appliedFilter = FilterPerFrameFreq(frameWithZeros, fftFilter);

                for (int j = 0; j < appliedFilter.Length; j++)
                    result[i * frameOffset + j] += appliedFilter[j];

           

            }

            float multi = 1 / result.Max() ;
            for (int i = 0; i < result.Length; i++)
            {
                result[i] *= multi;
            }

            return result;
        }


        public static void WriteSound(float[] audioData, string fileName)
        {
            byte[] byteData = ConvertAudioToBytes(audioData);
            WriteSound(byteData, fileName);
        }

        public static void WriteSound(byte[] byteAudioData, string fileName)
        {
            using (WaveFileWriter writer = new WaveFileWriter(fileName, WaveFormat.CreateIeeeFloatWaveFormat(44100, 1)))
            {
                writer.Write(byteAudioData, 0, byteAudioData.Length * sizeof(byte));
                //writer.Write(byteAudioData);
            }

            // writer.Write(byteAudioData);
            // writer.Flush();
        }

        public static byte[] ConvertAudioToBytes(float[] audioData)
        {
            byte[] byteAudioData = new byte[audioData.Length * sizeof(float)];
            Buffer.BlockCopy(audioData, 0, byteAudioData, 0, byteAudioData.Length);
            return byteAudioData;
        }
    }
}
