using BlazorExtensions.Services;
using Model.Design;
using Model.Design.Content;
using Model.Design.Content.Controls;

namespace BlazorExtensions.InputHandling.HitTest
{
    public class HitTestStrategyFactory : IHitTestStrategyFactory
    {
        private readonly IImageContentService _imageContentService;

        public HitTestStrategyFactory(IImageContentService imageContentService)
        {
            _imageContentService = imageContentService;
        }

        public IHitTestStrategy Create(Element element)
        {
            switch (element.Content.ElementContentCase)
            {
                case ElementContent.ElementContentOneofCase.ClosedVector:
                    {
                        switch (element.Content.ClosedVector.Controls.ControlsCase)
                        {
                            case ClosedVectorControls.ControlsOneofCase.Rectangle:
                                return new RectangleHitTestStrategy(element);

                            default: throw new NotSupportedException();
                        }
                    }

                case ElementContent.ElementContentOneofCase.Image:
                    return new ImageHitTestStrategy(element, _imageContentService);

                default: throw new NotSupportedException();
            }
        }
    }
}
