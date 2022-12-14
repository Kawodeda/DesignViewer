namespace DesignViewer.Server.Options
{
    public class AssetsStorageOptions
    {
        public const string AssetsStorage = "AssetsStorage";

        public string ImagesPath { get; set; } = string.Empty;

        public string[] ImagesExtensions { get; set; } = Array.Empty<string>();

        public string DefaultImageExtension { get; set; } = string.Empty;
    }
}
