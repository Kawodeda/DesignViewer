using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aurigma.Design.Appearance;
using Aurigma.Design.Appearance.Color;
using Aurigma.Design.Content;
using Aurigma.Design.Content.Controls;
using Aurigma.Design.Math;

namespace Aurigma.Design
{
    public sealed partial class Design
    {
        public static Design CreateBlank()
        {
            const string defaultName = "untitled";
            Color white = new Color()
            {
                Process = new ProcessColor()
                {
                    Alpha = 255,
                    Rgb = new RgbColor()
                    {
                        R = 255,
                        G = 255,
                        B = 255
                    }
                }
            };
            Size defaultSize = new Size()
            {
                Width = 200f,
                Height = 200f
            };
            Brush defaultBrush = new Brush()
            {
                Solid = new SolidBrush()
                {
                    Color = white
                }
            };
            Affine2DMatrix defaultBasis = Affine2DMatrix.CreateIdentity();
            Sides defaultSides = new Sides()
            {
                Left = 0,
                Top = 0,
                Right = 0,
                Bottom = 0
            };
            TrimSettings defaultTrimSettings = new TrimSettings()
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
