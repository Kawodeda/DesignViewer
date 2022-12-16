﻿using BlazorExtensions.Rendering.Strategies;
using BlazorExtensions.Services;
using BlazorExtensions.Services.JsInterop;
using Model.Design;
using Model.Design.Content;

namespace BlazorExtensions.Rendering
{
    public class ElementDrawStrategyFactory : IElementDrawStrategyFactory
    {
        private readonly IJsModulesProvider _jsModulesProvider;
        private readonly IImageContentService _imageContentService;

        public ElementDrawStrategyFactory(
            IJsModulesProvider jsModulesProvider, 
            IImageContentService imageContentService)
        {
            _jsModulesProvider = jsModulesProvider;
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
                                return new RectangleDrawStrategy(element);
                            default:
                                throw new NotSupportedException();
                        }
                    }

                case ElementContent.ElementContentOneofCase.Image:
                    return new ImageDrawStrategy(element, _imageContentService, _jsModulesProvider);

                default:
                    throw new NotSupportedException();
            }
        }
    }
}
