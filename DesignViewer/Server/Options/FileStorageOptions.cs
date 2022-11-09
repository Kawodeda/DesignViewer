namespace BlazorViewer.Server.Options
{
    public class FileStorageOptions
    {
        public const string FileStorage = "FileStorage";

        public string Path { get; set; } = string.Empty;
        public string FileExtension { get; set; } = string.Empty;
    }
}
