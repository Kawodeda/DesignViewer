using BlazorExtensions.Rendering.Strategies;
using Model.Design;
using Model.Design.Content;

namespace BlazorExtensions.Rendering
{
    public class ElementDrawStrategyFactory : IElementDrawStrategyFactory
    {
        private readonly IImageRenderer _imageRenderer;

        public ElementDrawStrategyFactory(IImageRenderer imageRenderer)
        {
            _imageRenderer = imageRenderer;
        }

        public IDrawStrategy Create(Element element)
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

                case ElementContent.ElementContentOneofCase.Image:
                    return new ImageDrawStrategy(element, _imageRenderer);

                default:
                    throw new NotSupportedException();
            }
        }
    }
}
