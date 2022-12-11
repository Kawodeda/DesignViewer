using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using Model.Design.Appearance.Color;
using Color = Model.Design.Appearance.Color.Color;

namespace Model.Design
{
    public class ColorConverter
    {
        private static readonly string _htmlRgbTemplate = "rgb({0},{1},{2})";
        private static readonly string _htmlRgbaTemplate = "rgba({0},{1},{2},{3})";
        private static readonly Regex _rgbRegex = new Regex("rgb\\((\\d{1,3}),\\s*(\\d{1,3}),\\s*(\\d{1,3})\\)");
        private static readonly Regex _rgbaRegex = new Regex("rgba\\((\\d{1,3}),\\s*(\\d{1,3}),\\s*(\\d{1,3}),\\s*([01](\\.\\d+)?)\\)");
        private static readonly Regex _hexRegex = new Regex("#(?:[a-f]|\\d){6}");

        private static readonly IReadOnlyDictionary<Regex, Func<Match, Color>> _parsers
            = new Dictionary<Regex, Func<Match, Color>>()
            {
                { _hexRegex, ParseHex },
                { _rgbRegex, ParseRgb },
                { _rgbaRegex, ParseRgba }
            };

        public static System.Drawing.Color ToGdi(RgbColor rgb, uint alpha = 255)
        {
            return System.Drawing.Color.FromArgb((int)alpha, (int)rgb.R, (int)rgb.G, (int)rgb.B);
        }

        public static Color FromGdi(System.Drawing.Color color)
        {
            return new Color()
            {
                Process = new ProcessColor()
                {
                    Rgb = new RgbColor()
                    {
                        R = color.R,
                        G = color.G,
                        B = color.B
                    },
                    Alpha = color.A
                }
            };
        }

        public static string ToHtml(RgbColor rgb, uint alpha = 255)
        {
            if (alpha >= 255)
            {
                return string.Format(_htmlRgbTemplate, rgb.R, rgb.G, rgb.B);
            }

            return string.Format(_htmlRgbaTemplate, rgb.R, rgb.G, rgb.B, ColorUtils.AlphaToRelativeString(alpha));
        }

        public static Color FromHtml(string htmlColor)
        {
            var entry = _parsers.FirstOrDefault(entry => entry.Key.IsMatch(htmlColor));
            if (entry.Equals(default(KeyValuePair<Regex, Func<Match, Color>>)))
            {
                throw new NotSupportedException($"Couldn't parse given color: {htmlColor}");
            }

            return entry.Value(entry.Key.Match(htmlColor));
        }

        public static string ToHex(RgbColor rgb)
        {
            return $"#{rgb.R:x2}{rgb.G:x2}{rgb.B:x2}";
        }

        private static Color ParseHex(Match hexMatch)
        {
            var color = ColorTranslator.FromHtml(hexMatch.Value);

            return FromGdi(color);
        }

        private static Color ParseRgb(Match rgbMatch)
        {
            return new Color()
            {
                Process = new ProcessColor()
                {
                    Rgb = new RgbColor()
                    {
                        R = Convert.ToUInt32(rgbMatch.Groups[1].Value),
                        G = Convert.ToUInt32(rgbMatch.Groups[2].Value),
                        B = Convert.ToUInt32(rgbMatch.Groups[3].Value)
                    },
                    Alpha = 255
                }
            };
        }

        private static Color ParseRgba(Match rgbaMatch)
        {
            return new Color()
            {
                Process = new ProcessColor()
                {
                    Rgb = new RgbColor()
                    {
                        R = Convert.ToUInt32(rgbaMatch.Groups[1].Value),
                        G = Convert.ToUInt32(rgbaMatch.Groups[2].Value),
                        B = Convert.ToUInt32(rgbaMatch.Groups[3].Value)
                    },
                    Alpha = (uint)(Convert.ToSingle(rgbaMatch.Groups[4].Value, CultureInfo.InvariantCulture) * 255)
                }
            };
        }
    }
}
