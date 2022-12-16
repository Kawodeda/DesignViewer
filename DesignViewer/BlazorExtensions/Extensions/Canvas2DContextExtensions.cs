using Blazor.Extensions.Canvas.Canvas2D;
using Model.Design.Math;

namespace BlazorExtensions.Extensions
{
    public static class Canvas2DContextExtensions
    {
        public static async Task SetTransformAsync(this Canvas2DContext context, Affine2DMatrix transform)
        {
            await context.SetTransformAsync(
                transform.M11, 
                transform.M12, 
                transform.M21, 
                transform.M22, 
                transform.D1, 
                transform.D2);
        }

        public static async Task TransformAsync(this Canvas2DContext context, Affine2DMatrix transform)
        {
            await context.TransformAsync(
                transform.M11,
                transform.M12,
                transform.M21,
                transform.M22,
                transform.D1,
                transform.D2);
        }
    }
}
