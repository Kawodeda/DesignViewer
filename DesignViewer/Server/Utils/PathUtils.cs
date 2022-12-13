using Microsoft.AspNetCore.StaticFiles;

namespace DesignViewer.Server.Utils
{
    public static class PathUtils
    {
        public static string GetSearchPattern(string extension)
        {
            return $"*{extension}";
        }
    }
}
