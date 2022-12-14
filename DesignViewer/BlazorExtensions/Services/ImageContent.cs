using Microsoft.JSInterop;
using Model.Design.Math;

namespace BlazorExtensions.Services
{
    public class ImageContent
    {
        public ImageContent(IJSObjectReference htmlImage, Size size)
        {
            HtmlImage = htmlImage;
            Size = size;
        }

        public IJSObjectReference HtmlImage { get; }

        public Size Size { get; }
    }
}
