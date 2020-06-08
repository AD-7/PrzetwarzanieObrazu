using System;
using System.Collections.Generic;

namespace Audio.Classes
{
    public class SoundPointComparer : IEqualityComparer<SoundPoint>
    {
        public SoundPointComparer(float precision)
        {
            _precision = precision;
        }

        private readonly float _precision;

        public bool Equals(SoundPoint first, SoundPoint second)
        {
            return Math.Abs(first.Value - second.Value) < _precision && Math.Abs(first.Value - second.Value) < _precision;
        }

        public int GetHashCode(SoundPoint obj)
        {
            return 0;
        }
    }
}
