using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio.Classes
{
    public static class Extensions
    {
        public static bool IsAbout(this double first, double second, double precisionMultiplier = 8)
        {
            return Math.Abs(second - first) < Math.Max(1E-06 * Math.Max(Math.Abs(first), Math.Abs(second)),
                precisionMultiplier);
        }

        public static bool IsAbout(this float first, float second, float precisionMultiplier = 8)
        {
            return Math.Abs(second - first) < Math.Max(1E-06 * Math.Max(Math.Abs(first), Math.Abs(second)),
                precisionMultiplier);
        }

        public static IEnumerable<T> CheckIfEmpty<T>(this IEnumerable<T> @this)
        {
            if (@this.Any()) return @this;
            return new T[1];
        }
    }
}
