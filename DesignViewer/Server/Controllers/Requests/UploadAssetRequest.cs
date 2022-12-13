using DesignViewer.Server.Dtos;
using System.ComponentModel.DataAnnotations;

namespace DesignViewer.Server.Controllers.Requests
{
    public class UploadAssetRequest
    {
        [Required]
        public AssetDto Info { get; set; } = default!;

        [Required]
        public IFormFile Content { get; set; } = default!;
    }
}
