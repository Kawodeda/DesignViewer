namespace BlazorViewer.Server.Services
{
    public interface INameGeneratorService
    {
        public string Generate(string template = "");
    }
}
