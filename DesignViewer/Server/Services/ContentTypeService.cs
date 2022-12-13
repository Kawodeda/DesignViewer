using Microsoft.AspNetCore.StaticFiles;
using System.Diagnostics.CodeAnalysis;

namespace DesignViewer.Server.Services
{
    public class ContentTypeService : IContentTypeService
    {
        private readonly FileExtensionContentTypeProvider _contentTypeProvider;
        private readonly IReadOnlyDictionary<string, string> _extensionByType
            = new Dictionary<string, string>()
            {
                { "image/gif", ".gif" },
                { "image/jpeg", ".jpeg" },
                { "image/png", ".png" },
                { "image/webp", ".webp" }
            };

        public ContentTypeService()
        {
            _contentTypeProvider = new FileExtensionContentTypeProvider();
        }

        public bool TryGetContentType(string subpath, [MaybeNullWhen(false)] out string contentType)
        {
            return _contentTypeProvider.TryGetContentType(subpath, out contentType);
        }

        public bool TryGetExtension(string contentType, [MaybeNullWhen(false)] out string extension)
        {
            return _extensionByType.TryGetValue(contentType, out extension);
        }
    }
}
