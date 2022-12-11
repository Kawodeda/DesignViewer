using System.Globalization;

namespace Model.Design
{
    public static class ColorUtils
    {
        public static string AlphaToRelativeString(uint alpha)
        {
            var format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ".";

            return ((float)alpha / 255f).ToString(format);
        }
    }
}
