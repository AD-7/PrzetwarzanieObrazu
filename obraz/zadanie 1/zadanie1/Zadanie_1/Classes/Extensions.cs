using System.Drawing;

namespace Zadanie_1.Classes
{
    public static class Extensions
    {
        public static int GetGrayScale(this Color @this)
        {
            return (int) (0.299 * @this.R + 0.587 * @this.G + 0.114 * @this.B);
        }

        public static Color ToMonoColor(this int @this)
        {
            var value = @this < 0 ? 0 : @this > 255 ? 255 : @this;
            return Color.FromArgb(value, value, value);
        }
    }
}