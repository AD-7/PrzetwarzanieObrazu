using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
