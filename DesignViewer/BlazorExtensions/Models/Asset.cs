using ApiClient;

namespace BlazorExtensions.Models
{
    public class Asset
    {
        public Asset(AssetDto info, string imageUrl)
        {
            Info = info;
            ImageUrl = imageUrl;
        }

        public AssetDto Info { get; }

        public string ImageUrl { get; }
    }
}
