using System.IO.Abstractions;

namespace DesignViewer.Server.Services.FileStorage
{
    public interface IFileStorageService
    {
        Stream ReadFile(string path);

        IFileInfo CreateFile(string path, Stream content);

        IFileInfo UpdateFile(string path, Stream content);

        IFileInfo GetFileInfo(string path);

        IEnumerable<IFileInfo> GetFileInfos(string path, IEnumerable<string> searchPatterns);

        IEnumerable<IFileInfo> GetFileInfos(string path, string searchPattern);

        IEnumerable<IFileInfo> GetFileInfos(string path);

        void DeleteFile(string path);
    }
}
