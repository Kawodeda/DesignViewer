using Model.Design;
using Model.Design.Content;
using BlazorExtensions.Rendering.Strategies;

namespace BlazorExtensions.Rendering
{
    public class DrawStrategyFactory
    {
        public static IElementDrawStrategy Create(Element element)
        {
            switch (element.Content.ElementContentCase)
            {
                case ElementContent.ElementContentOneofCase.ClosedVector:
                    {
                        switch (element.Content.ClosedVector.Controls.ControlsCase)
                        {
                            case Model.Design.Content.Controls.ClosedVectorControls.ControlsOneofCase.Rectangle:
                                return new RectangleDrawStrategy(element);
                            default:
                                throw new NotSupportedException();
                        }
                    }

                default:
                    throw new NotSupportedException();
            }
        }
    }
}
