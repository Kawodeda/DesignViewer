using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions.TestingHelpers;
using System.Linq;
using Aurigma.Design;
using BlazorViewer.Server.Dtos;
using BlazorViewer.Server.Exceptions;
using BlazorViewer.Server.Options;
using BlazorViewer.Server.Services;
using Google.Protobuf;
using Microsoft.Extensions.Options;
using Moq;
using NUnit.Framework;

namespace ServerTests
{
    public class DesignFileStorageServiceTests
    {
        private const string DefaultFilename = "design";

        private FileStorageOptions _options;
        private IOptions<FileStorageOptions> _wrappedOptions;
        private INameGeneratorService _nameGeneratorService;

        [SetUp]
        public void Init()
        {
            _options = new FileStorageOptions
            {
                Path = "Storage/Designs",
                FileExtension = ".dat"
            };
            _wrappedOptions = Options.Create(_options);

            var mockNameGenerator = new Mock<INameGeneratorService>();
            mockNameGenerator
                .Setup(x => x.Generate(It.IsAny<string>()))
                .Returns<string>(x => DefaultFilename);
            _nameGeneratorService = mockNameGenerator.Object;
        }

        [Test]
        public void For_UploadDesign_Expect_FileContainingContentIsCreated()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddDirectory(_options.Path);

            var service = new DesignFileStorageService(
                _wrappedOptions,
                _nameGeneratorService,
                fileSystem);

            Design design = Design.CreateBlank();
            Stream designStream = new MemoryStream(design.ToByteArray());

            service.UploadDesign(designStream);

            string expectedFile = Path.Combine(
                _options.Path, 
                $"{DefaultFilename}{_options.FileExtension}");
            
            using (Stream input = fileSystem.File.OpenRead(expectedFile))
            {
                var expected = design;
                Design actual = Design.Parser.ParseFrom(input);
                Assert.AreEqual(expected, actual);
            }
        }

        [Test]
        public void For_UploadDesign_Expect_ResultIsMetadataOfCreatedDesign()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddDirectory(_options.Path);

            var service = new DesignFileStorageService(
                _wrappedOptions,
                _nameGeneratorService,
                fileSystem);

            Design design = Design.CreateBlank();
            Stream designStream = new MemoryStream(design.ToByteArray());

            var expected = new DesignDto
            {
                Name = DefaultFilename
            };

            DesignDto actual = service.UploadDesign(designStream);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_UploadDesignName_Expect_FileContainingContentIsCreated()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddDirectory(_options.Path);

            var service = new DesignFileStorageService(
                _wrappedOptions,
                _nameGeneratorService,
                fileSystem);

            Design design = Design.CreateBlank();
            Stream designStream = new MemoryStream(design.ToByteArray());
            string name = "design";

            service.UploadDesign(designStream, name);

            string expectedFile = Path.Combine(
                _options.Path,
                $"{name}{_options.FileExtension}");

            using (Stream input = fileSystem.File.OpenRead(expectedFile))
            {
                var expected = design;
                Design actual = Design.Parser.ParseFrom(input);
                Assert.AreEqual(expected, actual);
            }
        }

        [Test]
        public void For_UploadDesignName_Expect_ResultIsMetadataOfCreatedDesign()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddDirectory(_options.Path);

            var service = new DesignFileStorageService(
                _wrappedOptions,
                _nameGeneratorService,
                fileSystem);

            Design design = Design.CreateBlank();
            Stream designStream = new MemoryStream(design.ToByteArray());
            string name = "design";

            var expected = new DesignDto
            {
                Name = name
            };

            DesignDto actual = service.UploadDesign(designStream, name);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void When_UseUploadDesignNameWithExistingName_Expect_FileAlreadyExistException()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddDirectory(_options.Path);

            string filename = "design";
            string path = fileSystem.Path
                .Combine(_options.Path, $"{filename}{_options.FileExtension}");

            Design design = Design.CreateBlank();
            using (Stream output = fileSystem.File.Create(path))
            {
                design.WriteTo(output);
            }

            var service = new DesignFileStorageService(
                _wrappedOptions,
                _nameGeneratorService,
                fileSystem);

            Stream designStream = new MemoryStream(design.ToByteArray());
            string existingName = filename;

            Assert.Throws(
                typeof(FileAlreadyExistException),
                () => service.UploadDesign(designStream, existingName));
        }

        [Test]
        public void For_GetDesignInfo_Expect_ResultIsMetadataOfDesignWithGivenName()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddDirectory(_options.Path);

            string filename = "design1";
            string path = fileSystem.Path
                .Combine(_options.Path, $"{filename}{_options.FileExtension}");

            Design design = Design.CreateBlank();
            using (Stream output = fileSystem.File.Create(path))
            {
                design.WriteTo(output);
            }

            var service = new DesignFileStorageService(
                _wrappedOptions,
                _nameGeneratorService,
                fileSystem);

            var expected = new DesignDto
            {
                Name = filename
            };

            DesignDto actual = service.GetDesignInfo(filename);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void When_UseGetDesignInfoWithNonExistingName_Expect_FileNotFoundExceptionIsThrown()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddDirectory(_options.Path);

            var service = new DesignFileStorageService(
                _wrappedOptions,
                _nameGeneratorService,
                fileSystem);

            string nonExistingName = "design1";

            Assert.Throws(
                typeof(FileNotFoundException),
                () => service.GetDesignInfo(nonExistingName));
        }

        [Test]
        public void For_GetDesignContent_Expect_ResultIsContentOfDesignWithGivenName()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddDirectory(_options.Path);

            string filename = "design1";
            string path = fileSystem.Path
                .Combine(_options.Path, $"{filename}{_options.FileExtension}");

            Design design = Design.CreateBlank();
            using (Stream output = fileSystem.File.Create(path))
            {
                design.WriteTo(output);
            }

            var service = new DesignFileStorageService(
                _wrappedOptions,
                _nameGeneratorService,
                fileSystem);

            Stream expected = new MemoryStream(design.ToByteArray());
            Stream actual = service.GetDesignContent(filename);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void When_UseGetDesignContentWithNonExistingName_Expect_FileNotFoundExceptionIsThrown()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddDirectory(_options.Path);

            var service = new DesignFileStorageService(
                _wrappedOptions,
                _nameGeneratorService,
                fileSystem);

            string nonExistingName = "design1";

            Assert.Throws(
                typeof(FileNotFoundException),
                () => service.GetDesignContent(nonExistingName));
        }

        [Test]
        public void For_ListDesigns_Expect_ResultIsMetadataOfAllDesigns()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddDirectory(_options.Path);

            List<string> filenames = new List<string>()
            {
                "design1",
                "design2",
                "design3"
            };

            foreach (var filename in filenames)
            {
                string path = fileSystem.Path
                .Combine(_options.Path, $"{filename}{_options.FileExtension}");

                Design design = Design.CreateBlank();
                using (Stream output = fileSystem.File.Create(path))
                {
                    design.WriteTo(output);
                }
            }

            var service = new DesignFileStorageService(
                _wrappedOptions,
                _nameGeneratorService,
                fileSystem);

            IEnumerable<DesignDto> expected = filenames
                .Select(x => new DesignDto()
                {
                    Name = x
                });

            IEnumerable<DesignDto> actual = service.ListDesigns();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void For_UpdateDesign_Expect_DesignWithGivenNameIsOverwrittenWithContent()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddDirectory(_options.Path);

            string filename = "design1";
            string path = fileSystem.Path
                .Combine(_options.Path, $"{filename}{_options.FileExtension}");

            Design design = Design.CreateBlank();
            using (Stream output = fileSystem.File.Create(path))
            {
                design.WriteTo(output);
            }

            var service = new DesignFileStorageService(
                _wrappedOptions,
                _nameGeneratorService,
                fileSystem);

            Design updatedDesign = Design.CreateBlank();
            updatedDesign
                .Surfaces
                .First()
                .Name = "updated";
            byte[] updatedBytes = updatedDesign.ToByteArray();
            Stream updatedStream = new MemoryStream(updatedBytes);

            service.UpdateDesign(filename, updatedStream);

            using (Stream input = fileSystem.File.OpenRead(path))
            {
                var expected = updatedDesign;
                Design actual = Design.Parser.ParseFrom(input);
                Assert.AreEqual(expected, actual);
            }
        }

        [Test]
        public void For_UpdateDesign_Expect_ResultIsMetadataOfUpdatedDesign()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddDirectory(_options.Path);

            string filename = "design1";
            string path = fileSystem.Path
                .Combine(_options.Path, $"{filename}{_options.FileExtension}");

            Design design = Design.CreateBlank();
            using (Stream output = fileSystem.File.Create(path))
            {
                design.WriteTo(output);
            }

            var service = new DesignFileStorageService(
                _wrappedOptions,
                _nameGeneratorService,
                fileSystem);

            Design updatedDesign = Design.CreateBlank();
            updatedDesign
                .Surfaces
                .First()
                .Name = "updated";
            byte[] updatedBytes = updatedDesign.ToByteArray();
            Stream updatedStream = new MemoryStream(updatedBytes);

            var expected = new DesignDto
            {
                Name = filename
            };

            DesignDto actual = service.UpdateDesign(filename, updatedStream);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void When_UseUpdateDesignWithNonExistingName_Expect_FileNotFoundExceptionIsThrown()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddDirectory(_options.Path);

            var service = new DesignFileStorageService(
                _wrappedOptions,
                _nameGeneratorService,
                fileSystem);

            Design updatedDesign = Design.CreateBlank();
            updatedDesign
                .Surfaces
                .First()
                .Name = "updated";
            byte[] updatedBytes = updatedDesign.ToByteArray();
            Stream updatedStream = new MemoryStream(updatedBytes);

            string nonExistingName = "design1";

            Assert.Throws(
                typeof(FileNotFoundException),
                () => service.UpdateDesign(nonExistingName, updatedStream));
        }

        [Test]
        public void For_DeleteDesign_Expect_FileWithGivenNameIsDeleted()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddDirectory(_options.Path);

            string filename = "design1";
            string path = fileSystem.Path
                .Combine(_options.Path, $"{filename}{_options.FileExtension}");

            Design design = Design.CreateBlank();
            using (Stream output = fileSystem.File.Create(path))
            {
                design.WriteTo(output);
            }

            var service = new DesignFileStorageService(
                _wrappedOptions,
                _nameGeneratorService,
                fileSystem);

            service.DeleteDesign(filename);

            bool isExist = fileSystem.FileExists(path);

            Assert.IsFalse(isExist);
        }

        [Test]
        public void When_UseDeleteDesignWithNonExistingName_Expect_FileNotFoundExceptionIsThrown()
        {
            var fileSystem = new MockFileSystem();
            fileSystem.AddDirectory(_options.Path);

            var service = new DesignFileStorageService(
                _wrappedOptions,
                _nameGeneratorService,
                fileSystem);

            string nonExistingName = "design1";

            Assert.Throws(
                typeof(FileNotFoundException),
                () => service.DeleteDesign(nonExistingName));
        }
    }
}
