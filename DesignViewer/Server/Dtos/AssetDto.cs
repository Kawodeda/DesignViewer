using System.ComponentModel;

namespace DesignViewer.Server.Dtos
{
    public class AssetDto
    {
        public string StorageId { get; set; } = string.Empty;

        /// <summary>
        /// Stores content MIME type
        /// </summary>
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Stores content length in bytes
        /// </summary>
        public long? Size { get; set; }
    }
}
