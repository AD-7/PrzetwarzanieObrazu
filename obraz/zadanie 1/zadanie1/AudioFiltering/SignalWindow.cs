using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioFiltering
{
    public enum WindowType { Rectangle, VonnHann, Hamming }


    public class SignalWindow
    {

        public static  float[] MultiplyByWindow(float[] data, bool causal, WindowType windowType)
        {
            switch (windowType)
            {
                case WindowType.Rectangle:
                    return SignalWindow.RectangleMultiply(data, causal);


                case WindowType.VonnHann:
                    return SignalWindow.VonHannMultiply(data, causal);

                case WindowType.Hamming:
                    return SignalWindow.HammingMultiply(data, causal);

                default:

                    return SignalWindow.RectangleMultiply(data, causal);
            }
        }
        public static float[] ValuesByWindow(int frameSIZE, bool causal, WindowType windowType)
        {
            switch (windowType)
            {
                case WindowType.Rectangle:
                    return SignalWindow.Rectangle(frameSIZE, causal);


                case WindowType.VonnHann:
                    return SignalWindow.VonHann(frameSIZE, causal);

                case WindowType.Hamming:
                    return SignalWindow.Hamming(frameSIZE, causal);

                default:

                    return SignalWindow.Rectangle(frameSIZE, causal);
            }
        }
        public static float[] FlipResult(float[] result)
        {
            int toMove = result.Length / 2;
            float[] newResult = new float[result.Length];
            for (int i = 0; i < toMove; i++)
            {
                newResult[i + toMove] = result[i];
                newResult[i] = result[i + toMove];
            }

            if (result.Length % 2 == 1)
                newResult[toMove] = result[toMove + toMove];
            return newResult;
        }


        public static float[] RectangleMultiply(float[] data, bool causal)
        {
            return data.Clone() as float[];
        }
        public static float[] Rectangle(int size, bool causal)
        {
            float[] result = new float[size];
            for (int i = 0; i < size; i++)
                result[i] = 1;

            return result;
        }

        public static float[] VonHannMultiply(float[] data, bool causal)
        {
            float[] result = data.Select((v, n) => v * (0.5f - (0.5f * (float)Math.Cos((2 * Math.PI * n) / (data.Length - 1)))))
                .ToArray();

            return causal ? result : FlipResult(result);
        }

        public static float[] VonHann(int size, bool causal)
        {
            float[] result = new float[size];
            for (int i = 0; i < size; i++)
                result[i] = (0.5f - (0.5f * (float)Math.Cos((2 * Math.PI * i) / (size - 1))));

            return causal ? result : FlipResult(result);
        }
        public static float[] HammingMultiply(float[] data, bool causal)
        {
            float[] result = data.Select((v, n) => v * (0.53836f - (0.46164f * (float)Math.Cos((2 * Math.PI * n) / (data.Length - 1)))))
                .ToArray();

            return causal ? result : FlipResult(result);
        }

        public static float[] Hamming(int size, bool causal)
        {
            float[] result = new float[size];
            for (int i = 0; i < size; i++)
                result[i] = (0.53836f - (0.46164f * (float)Math.Cos((2 * Math.PI * i) / (size - 1))));
            result[0] /= 2f;
            result[size - 1] /= 2f;
            return causal ? result : FlipResult(result);
        }
    }
}
