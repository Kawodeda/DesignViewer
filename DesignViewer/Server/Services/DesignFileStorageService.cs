using System.IO.Abstractions;
using BlazorViewer.Server.Dtos;
using BlazorViewer.Server.Exceptions;
using BlazorViewer.Server.Options;
using Microsoft.Extensions.Options;

namespace BlazorViewer.Server.Services
{
    public class DesignFileStorageService : IDesignStorageService
    {
        private readonly FileStorageOptions _options;
        private readonly INameGeneratorService _nameGeneratorService;
        private readonly IFileSystem _fileSystem;

        public DesignFileStorageService(
            IOptions<FileStorageOptions> options,
            INameGeneratorService nameGeneratorService) 
            : this(options, nameGeneratorService, new FileSystem()) {}

        public DesignFileStorageService(
            IOptions<FileStorageOptions> options,
            INameGeneratorService nameGeneratorService,
            IFileSystem fileSystem)
        {
            _options = options.Value;
            _nameGeneratorService = nameGeneratorService;
            _fileSystem = fileSystem;
        }

        public DesignDto UploadDesign(Stream content)
        {
            string filename = _nameGeneratorService.Generate("design");

            return UploadDesign(content, filename);
        }

        public DesignDto UploadDesign(Stream content, string name)
        {
            string path = GetPath(name);

            CreateFile(path, content);

            return new DesignDto()
            {
                Name = name
            };
        }

        public DesignDto GetDesignInfo(string name)
        {
            string path = GetPath(name);
            var result = GetFileInfo(path);

            return result;
        }

        public Stream GetDesignContent(string name)
        {
            string path = GetPath(name);

            return GetFromPath(path);
        }

        public IEnumerable<DesignDto> ListDesigns()
        {
            return GetFileInfos();
        }

        public DesignDto UpdateDesign(string name, Stream content)
        {
            string path = GetPath(name);

            UpdateFile(path, content);

            return new DesignDto()
            {
                Name = name
            };
        }

        public void DeleteDesign(string name)
        {
            string path = GetPath(name);

            if(_fileSystem.File.Exists(path) == false)
            {
                throw new FileNotFoundException();
            }

            _fileSystem.File.Delete(path);
        }

        private Stream GetFromPath(string path)
        {
            return _fileSystem.File.OpenRead(path);
        }

        private void CreateFile(string path, Stream content)
        {
            if (_fileSystem.File.Exists(path))
            {
                throw new FileAlreadyExistException();
            }

            _fileSystem.Directory.CreateDirectory(_options.Path);
            using (Stream output = _fileSystem.File.Create(path))
            {
                content.CopyTo(output);
            }
        }

        private void UpdateFile(string path, Stream content)
        {
            using (Stream output = _fileSystem.File.Open(
                path, 
                FileMode.Truncate))
            {
                content.CopyTo(output);
            }
        }

        private string GetPath(string filename)
        {           
            return _fileSystem.Path
                .Combine(_options.Path, $"{filename}{_options.FileExtension}");
        }

        private IEnumerable<DesignDto> GetFileInfos()
        {
            return _fileSystem.Directory
                .EnumerateFiles(_options.Path, $"*{_options.FileExtension}")
                .Select(x => GetFileInfo(x));
        }

        private DesignDto GetFileInfo(string path)
        {
            if (_fileSystem.File.Exists(path) == false)
            {
                throw new FileNotFoundException();
            }

            string name = _fileSystem.Path.GetFileNameWithoutExtension(path);

            return new DesignDto()
            {
                Name = name
            };
        }
    }
}
