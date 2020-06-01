using System;
using System.Collections.Generic;

namespace Audio.Classes
{
    public class SoundPointComparer : IEqualityComparer<(float x, float y, float z, float w)>
    {
        public SoundPointComparer(float precision, int dimensions)
        {
            Precision = precision;
            Dimensions = dimensions;
        }

        public float Precision;
        public int Dimensions;

        public bool Equals((float x, float y, float z, float w) first, (float x, float y, float z, float w) second)
        {
            switch (Dimensions)
            {
                case 2:
                    return Math.Abs(first.x - second.x) < Precision &&
                           Math.Abs(first.y - second.y) < Precision;
                case 3:
                    return Math.Abs(first.x - second.x) < Precision &&
                           Math.Abs(first.y - second.y) < Precision &&
                           Math.Abs(first.w - second.w) < Precision;
                case 4:
                    return Math.Abs(first.x - second.x) < Precision &&
                           Math.Abs(first.y - second.y) < Precision &&
                           Math.Abs(first.w - second.w) < Precision &&
                           Math.Abs(first.z - second.z) < Precision;
            }

            return false;
        }

        public int GetHashCode((float x, float y, float z, float w) obj)
        {
            return 0;
        }
    }
}
