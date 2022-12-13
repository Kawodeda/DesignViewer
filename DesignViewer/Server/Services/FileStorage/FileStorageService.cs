using DesignViewer.Server.Exceptions;
using System.IO.Abstractions;

namespace DesignViewer.Server.Services.FileStorage
{
    public class FileStorageService : IFileStorageService
    {
        private const string WildcardSearchPattern = "*.*";

        private readonly IFileSystem _fileSystem;

        public FileStorageService(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public FileStorageService() : this(new FileSystem()) { }

        public Stream ReadFile(string path)
        {
            return _fileSystem.File.OpenRead(path);
        }

        public IFileInfo CreateFile(string path, Stream content)
        {
            if (_fileSystem.File.Exists(path))
            {
                throw new FileAlreadyExistException();
            }

            using (Stream output = _fileSystem.File.Create(path))
            {
                content.CopyTo(output);
            }

            return GetFileInfo(path);
        }

        public IFileInfo UpdateFile(string path, Stream content)
        {
            using (Stream output = _fileSystem.File.Open(
                path,
                FileMode.Truncate))
            {
                content.CopyTo(output);
            }

            return GetFileInfo(path);
        }

        public IFileInfo GetFileInfo(string path)
        {
            if (!_fileSystem.File.Exists(path))
            {
                throw new FileNotFoundException();
            }

            return _fileSystem.FileInfo.FromFileName(path);
        }

        public IEnumerable<IFileInfo> GetFileInfos(string path, IEnumerable<string> searchPatterns)
        {
            return searchPatterns
                .SelectMany(pattern =>
                    _fileSystem.Directory.EnumerateFiles(path, pattern))
                .Select(filePath => GetFileInfo(filePath));
        }

        public IEnumerable<IFileInfo> GetFileInfos(string path, string searchPattern)
        {
            return GetFileInfos(path, new string[] { searchPattern });
        }

        public IEnumerable<IFileInfo> GetFileInfos(string path)
        {
            return GetFileInfos(path, WildcardSearchPattern);
        }

        public void DeleteFile(string path)
        {
            if (!_fileSystem.File.Exists(path))
            {
                throw new FileNotFoundException();
            }

            _fileSystem.File.Delete(path);
        }
    }
}
