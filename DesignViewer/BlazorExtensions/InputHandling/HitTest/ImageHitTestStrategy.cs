using BlazorExtensions.Models;
using BlazorExtensions.Services;
using Model.Design;
using Model.Design.Content;
using Model.Design.Math;

namespace BlazorExtensions.InputHandling.HitTest
{
    public class ImageHitTestStrategy : BaseHitTestStrategy
    {
        private readonly IImageContentService _imageContentService;

        public ImageHitTestStrategy(Element element, IImageContentService imageContentService) 
            : base(element) 
        {
            _imageContentService = imageContentService;
        }

        public override bool HitTest(Point point, Affine2DMatrix transform)
        {
            Image image = _element.Content.Image;
            ImageContent? imageContent = _imageContentService.GetImageContent(image.StorageId);

            if (imageContent == null)
            {
                return false;
            }

            Point topLeftPos = _element.Position;
            Point scale = _element.Transform.ScaleFactor;
            Point size = new Point(
                imageContent.Size.Width * scale.X,
                imageContent.Size.Height * scale.Y);

            if (_element.ReferencePoint == ReferencePointType.Center)
            {
                topLeftPos -= size * 0.5f;
            }

            Point corner1 = topLeftPos;
            Point corner2 = topLeftPos + size;
            point *= _element.Transform.RotationMatrix * transform.Inverse();

            return point.X > corner1.X
                && point.X < corner2.X
                && point.Y > corner1.Y
                && point.Y < corner2.Y;
        }
    }
}
