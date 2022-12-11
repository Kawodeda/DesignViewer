namespace BlazorViewer.Server.Options
{
    public class DesignsStorageOptions
    {
        public const string DesignsStorage = "DesignsStorage";

        public string Path { get; set; } = string.Empty;
        public string FileExtension { get; set; } = string.Empty;
    }
}
