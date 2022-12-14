namespace BlazorExtensions.Services.Exceptions
{
    public class AssetLoadingException : Exception
    {
        public AssetLoadingException(string? message = null, string? storageId = null)
            : base(message)
        {
            StorageId = storageId;
        }

        public string? StorageId { get; }
    }
}
