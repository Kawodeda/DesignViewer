using BlazorExtensions.Viewports;

namespace BlazorExtensions.Commands.Parameters
{
    public class ZoomCommandParams
    {
        public float DeltaZoom { get; }

        public ZoomCommandParams(float zoom)
        {
            DeltaZoom = zoom;
        }
    }
}
