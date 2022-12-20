using Model.Design;

namespace BlazorExtensions.Commands.Parameters
{
    public class ResizeElementCommandParams
    {
        public ResizeElementCommandParams(Element element, float scaleX, float scaleY)
        {
            Element = element;
            ScaleX = scaleX;
            ScaleY = scaleY;
        }

        public Element Element { get; }

        public float ScaleX { get; }

        public float ScaleY { get; }
    }
}
