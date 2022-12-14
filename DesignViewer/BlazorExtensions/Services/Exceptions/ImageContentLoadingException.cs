namespace BlazorExtensions.Services.Exceptions
{
    public class ImageContentLoadingException : AssetLoadingException
    {
        public ImageContentLoadingException(string? message = null, string? storageId = null)
            : base(message, storageId) { }
    }
}
