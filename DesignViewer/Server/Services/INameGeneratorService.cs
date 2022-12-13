namespace DesignViewer.Server.Services
{
    public interface INameGeneratorService
    {
        public string Generate(string template = "");
    }
}
