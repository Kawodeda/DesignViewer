using BlazorExtensions.Viewports;

namespace BlazorExtensions.Commands.Parameters
{
    public class ScrollCommandParams
    {
        public float DeltaScrollX { get; set; }
        public float DeltaScrollY { get; set; }

        public ScrollCommandParams(float deltaScrollX, float deltaScrollY)
        {
            DeltaScrollX = deltaScrollX;
            DeltaScrollY = deltaScrollY;
        }
    }
}
