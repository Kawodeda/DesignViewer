using Aurigma.Design;
using Aurigma.Design.Math;

namespace BlazorExtensions.Commands.Parameters
{
    public class TranslateElementCommandParams
    {
        public Element Element { get; set; }

        public Point Shift { get; set; }

        public TranslateElementCommandParams(Element element, Point shift)
        {
            Element = element;
            Shift = shift;
        }
    }
}
