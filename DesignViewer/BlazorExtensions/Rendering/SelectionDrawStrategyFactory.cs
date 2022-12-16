using BlazorExtensions.Rendering.Strategies;
using BlazorExtensions.Rendering.Strategies.Selection;
using BlazorExtensions.Services;
using Model.Design;
using Model.Design.Content;

namespace BlazorExtensions.Rendering
{
    public class SelectionDrawStrategyFactory : ISelectionDrawStrategyFactory
    {
        private readonly IImageContentService _imageContentService;

        public SelectionDrawStrategyFactory(IImageContentService imageContentService)
        {
            _imageContentService = imageContentService;
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
                                return new RectangleSelectionDrawStrategy(element);
                            default:
                                throw new NotSupportedException();
                        }
                    }

                case ElementContent.ElementContentOneofCase.Image:
                    return new ImageSelectionDrawStrategy(element, _imageContentService);

                default:
                    throw new NotSupportedException();
            }
        }
    }
}
