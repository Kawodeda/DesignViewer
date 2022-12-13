using Model.Design;
using Model.Design.Content;
using BlazorExtensions.Rendering.Strategies;
using Microsoft.JSInterop;
using System.Reflection;

namespace BlazorExtensions.Rendering
{
    public class DrawStrategyFactory : IDrawStrategyFactory
    {
        private Task<IJSObjectReference> _jsRendering;

        public async Task<IElementDrawStrategy> Create(Element element)
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
