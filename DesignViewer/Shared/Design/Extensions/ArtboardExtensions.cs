using Aurigma.Design.Math;

namespace Aurigma.Design
{
    public sealed partial class Artboard
    {
        public Size ActualSize
        {
            get
            {
                return new Size()
                {
                    Width = Size.Width * Basis.M11,
                    Height = Size.Height * Basis.M22
                };
            }
        }
    }
}