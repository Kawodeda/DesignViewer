using BlazorExtensions.Models;

namespace BlazorExtensions.Services
{
    public interface IImageContentService
    {
        ImageContent? GetImageContent(string storageId);
    }
}
