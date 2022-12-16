using System.Globalization;

namespace Model.Utils
{
    public static class ColorUtils
    {
        public static string AlphaToRelativeString(uint alpha)
        {
            var format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ".";

            return (alpha / 255f).ToString(format);
        }
    }
}
