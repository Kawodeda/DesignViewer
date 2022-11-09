using BlazorViewer.Server.Dtos;

namespace BlazorViewer.Server.Services
{
    public interface IDesignStorageService
    {
        public DesignDto UploadDesign(Stream content);

        public DesignDto UploadDesign(Stream content, string name);

        public DesignDto GetDesignInfo(string name);

        public Stream GetDesignContent(string name);

        public IEnumerable<DesignDto> ListDesigns();

        public DesignDto UpdateDesign(string name, Stream content);

        public void DeleteDesign(string name);
    }
}
