using Model.Design;
using Model.Design.Math;

namespace BlazorExtensions.Commands.Parameters
{
    public class TranslateElementCommandParams
    {
        public Element Element { get; }

        public Point Shift { get; }

        public TranslateElementCommandParams(Element element, Point shift)
        {
            Element = element;
            Shift = shift;
        }
    }
}
