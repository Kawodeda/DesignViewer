using Aurigma.Design;

namespace BlazorExtensions
{
    public interface IElementCreator
    {
        public Element CreateDefaultRectangle();
        public Element CreateRandomRectangle();
    }
}