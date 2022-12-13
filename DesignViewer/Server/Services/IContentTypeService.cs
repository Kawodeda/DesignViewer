using Microsoft.AspNetCore.StaticFiles;
using System.Diagnostics.CodeAnalysis;

namespace DesignViewer.Server.Services
{
    public interface IContentTypeService : IContentTypeProvider
    {
        bool TryGetExtension(string contentType, [MaybeNullWhen(false)] out string extension);
    }
}
