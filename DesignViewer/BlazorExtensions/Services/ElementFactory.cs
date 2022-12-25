using Model.Design;
using Model.Design.Appearance;
using Model.Design.Appearance.Color;
using Model.Design.Content;
using Model.Design.Content.Controls;
using Model.Design.Math;

namespace BlazorExtensions.Services
{
    public class ElementFactory : IElementFactory
    {
        private Brush Black
        {
            get
            {
                return new Brush()
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
                                    R = 0,
                                    G = 0,
                                    B = 0
                                }
                            }
                        }
                    }
                };
            }
        }

        private Random _random = new Random();

        public Element CreateDefaultRectangle()
        {
            var rectangle = new Element()
            {
                Position = new Point(0, 0),
                ReferencePoint = ReferencePointType.Center,
                Transform = Affine2DMatrix.CreateIdentity(),
                Content = new ElementContent()
                {
                    ClosedVector = new ClosedVector()
                    {
                        Fill = Black,
                        Controls = new ClosedVectorControls()
                        {
                            Rectangle = new RectangleControls()
                            {
                                Corner1 = new Point(-50, -50),
                                Corner2 = new Point(50, 50)
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

        public Element CreateImage(string storageId, Point position, Affine2DMatrix transform)
        {
            var image = new Element
            {
                Position = position,
                Transform = transform,
                ReferencePoint = ReferencePointType.Center,
                Content = new ElementContent
                {
                    Image = new Image
                    {
                        StorageId= storageId,
                        Controls = new ImageControls
                        {
                            Rectangle= new RectangleControls
                            {
                                Corner1 = new Point(0, 0),
                                Corner2 = new Point(0, 0)
                            }
                        }
                    }
                }
            };
            return image;
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
