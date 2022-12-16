namespace BlazorExtensions.Viewports
{
    public interface IZoomable
    {
        public float Zoom { get; set; }

        public event EventHandler<ZoomChangedEventArgs> ZoomChanged;

        public float MinZoom { get; set; }

        public float MaxZoom { get; set; }
    }
}
