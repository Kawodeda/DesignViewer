using Blazor.Extensions.Canvas.Canvas2D;
using Model.Design;
using Model.Design.Content;
using Model.Design.Math;

namespace BlazorExtensions.Rendering
{
    public interface IImageRenderer
    {
        Task Render(
            Canvas2DContext context, 
            Image image, Point position, 
            Point scale, 
            ReferencePointType referencePoint = ReferencePointType.TopLeftCorner);
    }
}
