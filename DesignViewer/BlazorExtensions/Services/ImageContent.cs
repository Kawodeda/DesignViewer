using Microsoft.JSInterop;

namespace BlazorExtensions.Services
{
    public class ImageContent
    {
        public ImageContent(IJSObjectReference htmlImage)
        {
            HtmlImage = htmlImage;
        }

        public IJSObjectReference HtmlImage { get; }
    }
}
