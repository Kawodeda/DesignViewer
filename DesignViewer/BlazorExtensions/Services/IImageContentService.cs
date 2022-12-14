namespace BlazorExtensions.Services
{
    public interface IImageContentService
    {
        ImageContent? GetImageContent(string storageId);
    }
}
