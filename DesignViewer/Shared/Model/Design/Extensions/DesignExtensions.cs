using Model.Design.Appearance;
using Model.Design.Appearance.Color;
using Model.Design.Math;

namespace Model.Design
{
    public sealed partial class Design
    {
        public static Design CreateBlank()
        {
            const string defaultName = "untitled";
            var transparentWhite = new Color()
            {
                Process = new ProcessColor()
                {
                    Alpha = 0,
                    Rgb = new RgbColor()
                    {
                        R = 255,
                        G = 255,
                        B = 255
                    }
                }
            };
            var defaultSize = new Size()
            {
                Width = 200f,
                Height = 200f
            };
            var defaultBrush = new Brush()
            {
                Solid = new SolidBrush()
                {
                    Color = transparentWhite
                }
            };
            Affine2DMatrix defaultBasis = Affine2DMatrix.CreateIdentity();
            var defaultSides = new Sides()
            {
                Left = 0,
                Top = 0,
                Right = 0,
                Bottom = 0
            };
            var defaultTrimSettings = new TrimSettings()
            {
                Bleed = defaultSides,
                Slug = defaultSides
            };

            var blank = new Design();
            var surface = new Surface() 
            { 
                Name = defaultName
            };

            var artboard = new Artboard()
            {
                Name = defaultName,
                Size = defaultSize,
                Background = defaultBrush,
                Basis = defaultBasis,
                TrimSettings = defaultTrimSettings
            };

            var layer = new Layer()
            {
                Name = defaultName
            };

            surface.Artboards.Add(artboard);
            surface.Layers.Add(layer);

            blank.Surfaces.Add(surface);

            return blank;
        }
    }
}
