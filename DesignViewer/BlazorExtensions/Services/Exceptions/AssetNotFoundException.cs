namespace BlazorExtensions.Services.Exceptions
{
    public class AssetNotFoundException : AssetLoadingException
    {
        public AssetNotFoundException(string? message = null, string? storageId = null)
            : base(message, storageId) { }
    }
}
