namespace BlazorExtensions.Viewports
{
    public class ScrollChangedEventArgs
    {
        public ScrollChangedEventArgs(float scrollX, float scrollY, float deltaScrollX, float deltaScrollY)
        {
            ScrollX = scrollX;
            ScrollY = scrollY;
            DeltaScrollX = deltaScrollX;
            DeltaScrollY = deltaScrollY;
        }

        public float ScrollX { get; }

        public float ScrollY { get; }

        public float DeltaScrollX { get; }

        public float DeltaScrollY { get; }
    }
}
