using Aurigma.Design;
using Aurigma.Design.Appearance;
using Aurigma.Design.Appearance.Color;
using Aurigma.Design.Content;
using Aurigma.Design.Content.Controls;
using Aurigma.Design.Math;

namespace BlazorExtensions
{
    public class ElementCreator : IElementCreator
    {
        private readonly Brush Lavender = new Brush()
        {
            Solid = new SolidBrush()
            {
                Color = new Color()
                {
                    Process = new ProcessColor()
                    {
                        Alpha = 255,
                        Rgb = new RgbColor()
                        {
                            R = 230,
                            G = 230,
                            B = 250
                        }
                    }
                }
            }
        };

        private Random _random = new Random();

        public Element CreateDefaultRectangle()
        {
            var rectangle = new Element()
            {
                Position = new Point(0, 0),
                ReferencePoint = ReferencePointType.TopLeftCorner,
                Transform = Affine2DMatrix.CreateIdentity(),
                Content = new ElementContent()
                {
                    ClosedVector = new ClosedVector()
                    {
                        Fill = Lavender,
                        Controls = new ClosedVectorControls()
                        {
                            Rectangle = new RectangleControls()
                            {
                                Corner1 = new Point(0, 0),
                                Corner2 = new Point(48, 48)
                            }
                        }
                    }
                }
            };

            return rectangle;
        }

        public Element CreateRandomRectangle()
        {
            var rectangle = new Element()
            {
                Position = new Point(0, 0),
                ReferencePoint = ReferencePointType.TopLeftCorner,
                Transform = GetRandomRotate(),
                Content = new ElementContent()
                {
                    ClosedVector = new ClosedVector()
                    {
                        Fill = GetRandomBrush(),
                        Controls = new ClosedVectorControls()
                        {
                            Rectangle = new RectangleControls()
                            {
                                Corner1 = new Point(0, 0),
                                Corner2 = new Point(
                                    _random.Next(10, 64), 
                                    _random.Next(10, 64))
                            }
                        }
                    }
                }
            };

            return rectangle;
        }

        private Brush GetRandomBrush()
        {
            return new Brush()
            {
                Solid = new SolidBrush()
                {
                    Color = GetRandomColor(255)
                }
            };
        }

        private Color GetRandomColor(uint alpha)
        {
            return new Color()
            {
                Process = new ProcessColor()
                {
                    Alpha = alpha,
                    Rgb = new RgbColor()
                    {
                        R = (uint)_random.Next(0, 256),
                        G = (uint)_random.Next(0, 256),
                        B = (uint)_random.Next(0, 256)
                    }
                }
            };
        }

        private Affine2DMatrix GetRandomRotate()
        {
            return Affine2DMatrix
                .CreateRotate((float)(_random.NextDouble() * 6.28));
        }
    }
}
