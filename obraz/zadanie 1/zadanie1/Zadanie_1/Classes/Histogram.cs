using System.Collections.Generic;
using System.Drawing;

namespace Zadanie_1.Classes
{
    public class Histogram
    {
        public int[] Values { get; }


        private Histogram(FasterBitmap bitmap, int channel = 0)
        {
            Values = new int[256];
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    var color = bitmap.GetSingleChannel(i, j, channel);
                    Values[color]++;
                }
            }
        }

        public static List<Histogram> CreateHistogram(Image image)
        {
            var result = new Bitmap(image);
            var fasterBitmap = new FasterBitmap(result);
            var list = new List<Histogram>();
            fasterBitmap.LockBits();

            if (Image.GetPixelFormatSize(image.PixelFormat) == 8)
            {
                list.Add(new Histogram(fasterBitmap, 0));
                fasterBitmap.UnlockBits();
                return list;
            }

            list.Add(new Histogram(fasterBitmap, 0));
            list.Add(new Histogram(fasterBitmap, 1));
            list.Add(new Histogram(fasterBitmap, 2));
            fasterBitmap.UnlockBits();
            return list;
        }

        public int CalculateSum(int value)
        {
            var sum = 0;
            for (var m = 0; m <= value; m++)
            {
                sum += Values[m];
            }
            return sum;
        }
    }
}