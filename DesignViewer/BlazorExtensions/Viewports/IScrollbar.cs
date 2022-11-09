using Aurigma.Design.Math;

namespace BlazorExtensions.Viewports
{
    public interface IScrollbar : IScrollable
    {
        public bool IsHorizontalScrollbarShown { get; }

        public bool IsVerticalScrollbarShown { get; }

        public float ScrollbarSize { get; }

        public Size ContentSize { get; set; }

        public Sides ContentScrollMargin { get; set; }

        public Size ScrollableAreaSize { get; }

        public float VerticalScrollbarBodyPos { get; }

        public float HorizontalScrollbarBodyPos { get; }

        public float VerticalScrollbarBodyHeight { get; }

        public float HorizontalScrollbarBodyWidth { get; }

        public float VerticalScrollbarHeight { get; }

        public float HorizontalScrollbarWidth { get; }
    }
}
