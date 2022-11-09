namespace BlazorViewer.Server.Services
{
    public class FileNameGeneratorService : INameGeneratorService
    {
        public string Generate(string template = "")
        {
            return $"{template}{DateTime.Now.ToString("_dd_MM_yyyy_HH_mm_ss")}";
        }
    }
}
