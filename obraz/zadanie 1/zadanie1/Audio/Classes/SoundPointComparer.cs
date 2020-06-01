using System;
using System.Collections.Generic;

namespace Audio.Classes
{
    public class SoundPointComparer : IEqualityComparer<(float x, float y, float z)>
    {
        public SoundPointComparer(float precision)
        {
            Precision = precision;
        }

        public float Precision;

        public bool Equals((float x, float y, float z) first, (float x, float y, float z) second)
        {
            return Math.Abs(first.x - second.x) < Precision &&
                   Math.Abs(first.y - second.y) < Precision &&
                   Math.Abs(first.z - second.z) < Precision;
        }

        public int GetHashCode((float x, float y, float z) obj)
        {
            return 0;
        }
    }
}
