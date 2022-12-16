namespace BlazorExtensions.Viewports
{
    public class ZoomChangedEventArgs
    {
        public ZoomChangedEventArgs(float zoom, float deltaZoom) 
        {
            Zoom= zoom;
            DeltaZoom = deltaZoom;
        }

        public float Zoom { get; }

        public float DeltaZoom { get; }
    }
}
