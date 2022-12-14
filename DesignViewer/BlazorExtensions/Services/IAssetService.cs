namespace BlazorExtensions.Services
{
    public interface IAssetService
    {
        Task<Stream> GetAssetAsync(string storageId);

        Task RequestAssetAsync(string storageId);
    }
}
