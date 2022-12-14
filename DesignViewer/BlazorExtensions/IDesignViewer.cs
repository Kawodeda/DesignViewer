using BlazorExtensions.InputHandling.HitTest;
using Model.Design;
using Model.Design.Appearance.Color;
using Model.Design.Math;

namespace BlazorExtensions
{
    public interface IDesignViewer : IViewer
    {
        public Surface CurrentSurface { get; }

        public Element? SelectedElement { get; set; }

        public Color? SelectedElementFillColor { get; set; }

        public Affine2DMatrix Transform { get; }

        public Design Design { get; set; }

        public int CurrentSurfaceIndex { get; set; }

        public IHitTestStrategyFactory HitTestStrategyFactory { get; }
    }
}
