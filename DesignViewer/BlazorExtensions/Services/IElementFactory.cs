using Model.Design;
using Model.Design.Math;

namespace BlazorExtensions.Services
{
    public interface IElementFactory
    {
        public Element CreateDefaultRectangle();

        public Element CreateRandomRectangle();

        public Element CreateImage(string storageId, Point position, Affine2DMatrix transform);
    }
}