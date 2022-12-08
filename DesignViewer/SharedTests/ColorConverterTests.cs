using System;
using System.Collections.Generic;
using System.Drawing;
using Model.Design.Appearance.Color;
using NUnit.Framework;
using Color = Model.Design.Appearance.Color.Color;
using ColorConverter = Model.Design.ColorConverter;

namespace SharedTests
{
    public class ColorConverterTests
    {
        private static readonly IReadOnlyList<object> _toGdiCases = new List<object>()
        {
            new object[]
            {
                new RgbColor() { R = 255, G = 200, B = 100 },
                (uint)255
            },
            new object[]
            {
                new RgbColor() { R = 255, G = 255, B = 255 },
                (uint)160
            },
            new object[]
            {
                new RgbColor() { R = 0, G = 0, B = 0 },
                (uint)255
            },
            new object[]
            {
                new RgbColor() { R = 132, G = 240, B = 11 },
                (uint)154
            }
        };
        private static readonly IReadOnlyList<object> _toGdiOmitAlphaCases = new List<object>()
        {
            new RgbColor() { R = 255, G = 200, B = 100 },
            new RgbColor() { R = 255, G = 255, B = 255 },
            new RgbColor() { R = 0, G = 0, B = 0 },
            new RgbColor() { R = 180, G = 14, B = 201 }
        };
        private static readonly IReadOnlyList<object> _fromGdiCases = new List<object>()
        {
            System.Drawing.Color.FromArgb(100, 100, 10, 150),
            System.Drawing.Color.FromArgb(255, 11, 100, 200),
            System.Drawing.Color.Azure,
            System.Drawing.Color.BlueViolet
        };
        private static readonly IReadOnlyList<object> _toHtmlCases = new List<object>()
        {
            new object[]
            {
                new RgbColor() { R = 0, G = 200, B = 255 },
                (uint)255
            },
            new object[]
            {
                new RgbColor() { R = 255, G = 0, B = 255 },
                (uint)150
            },
            new object[]
            {
                new RgbColor() { R = 80, G = 39, B = 169 },
                (uint)11
            },
            new object[]
            {
                new RgbColor() { R = 255, G = 255, B = 255 },
                (uint)0
            },
        };
        private static readonly IReadOnlyList<object> _toHtmlOmitAlphaCases = new List<object>()
        {
            new RgbColor() { R = 255, G = 200, B = 100 },
            new RgbColor() { R = 0, G = 0, B = 1 },
            new RgbColor() { R = 0, G = 255, B = 0 },
            new RgbColor() { R = 111, G = 1, B = 198 }
        };
        private static readonly IReadOnlyList<object> _fromHtmlCases = new List<object>()
        {
            new object[]
            {
                "#ffffff",
                new Color()
                {
                    Process = new ProcessColor()
                    {
                        Rgb = new RgbColor() { R = 255, G = 255, B = 255 },
                        Alpha = 255
                    }
                }
            },
            new object[]
            {
                "#8ab7db",
                new Color()
                {
                    Process = new ProcessColor()
                    {
                        Rgb = new RgbColor() { R = 138, G = 183, B = 219 },
                        Alpha = 255
                    }
                }
            },
            new object[]
            {
                "rgb(180, 110, 230)",
                new Color()
                {
                    Process = new ProcessColor()
                    {
                        Rgb = new RgbColor() { R = 180, G = 110, B = 230 },
                        Alpha = 255
                    }
                }
            },
            new object[]
            {
                "rgba(250,19,199, 0.6)",
                new Color()
                {
                    Process = new ProcessColor()
                    {
                        Rgb = new RgbColor() { R = 250, G = 19, B = 199 },
                        Alpha = 153
                    }
                }
            },
        };
        private static readonly IReadOnlyList<object> _fromHtmlIncorrectCases = new List<object>()
        {
            "#ffqwertz",
            "purple11",
            "cmyk(10%,60%,99%,0%)",
            "rgba(11, 22, 33)"
        };

        [Test]
        [TestCaseSource(nameof(_toGdiCases))]
        public void For_ToGdi_Expect_ResultIsCorrespondingGdiColor(RgbColor rgb, uint alpha)
        {
            var expected = System.Drawing.Color.FromArgb((int)alpha, (int)rgb.R, (int)rgb.G, (int)rgb.B);
            var actual = ColorConverter.ToGdi(rgb, alpha);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCaseSource(nameof(_toGdiOmitAlphaCases))]
        public void When_CallToGdiOmitAlpha_Expect_ResultIsColorWithFullAlpha(RgbColor rgb)
        {
            var expected = System.Drawing.Color.FromArgb(255, (int)rgb.R, (int)rgb.G, (int)rgb.B);
            var actual = ColorConverter.ToGdi(rgb);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCaseSource(nameof(_fromGdiCases))]
        public void For_FromGdi_Expect_ResultIsCorrespondingColor(System.Drawing.Color color)
        {
            var expected = new Color()
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
            var actual = ColorConverter.FromGdi(color);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCaseSource(nameof(_toHtmlCases))]
        public void For_ToHtml_Expect_ResultIsCorrespondingHtmlColor(RgbColor rgb, uint alpha)
        {
            string expected = alpha >= 255
                ? $"rgb({rgb.R},{rgb.G},{rgb.B})"
                : $"rgba({rgb.R},{rgb.G},{rgb.B},{alpha / 255})";

            string actual = ColorConverter.ToHtml(rgb, alpha);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCaseSource(nameof(_toHtmlOmitAlphaCases))]
        public void When_CallToHtmlOmitAlpha_Expect_ResultIsHtmlRgbColor(RgbColor rgb)
        {
            string expected = $"rgb({rgb.R},{rgb.G},{rgb.B})";
            string actual = ColorConverter.ToHtml(rgb);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCaseSource(nameof(_fromHtmlCases))]
        public void For_FromHtml_Expect_ResultIsCorrespondingColor(string htmlColor, Color expected)
        {
            Color actual = ColorConverter.FromHtml(htmlColor);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCaseSource(nameof(_fromHtmlIncorrectCases))]
        public void When_PassIncorrectStringIntoFromHtml_Expect_NotSupportedExceptionIsThrown(string htmlColor)
        {
            Assert.Throws<NotSupportedException>(() => ColorConverter.FromHtml(htmlColor));
        }
    }
}
