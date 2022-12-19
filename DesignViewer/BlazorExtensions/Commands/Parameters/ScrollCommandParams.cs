using BlazorExtensions.Viewports;

namespace BlazorExtensions.Commands.Parameters
{
    public class ScrollCommandParams
    {
        public float DeltaScrollX { get; }
        public float DeltaScrollY { get; }

        public ScrollCommandParams(float deltaScrollX, float deltaScrollY)
        {
            DeltaScrollX = deltaScrollX;
            DeltaScrollY = deltaScrollY;
        }
    }
}
