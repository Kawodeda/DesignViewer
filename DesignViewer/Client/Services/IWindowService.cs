using Model.Design.Math;

namespace DesignViewer.Client.Services
{
    public interface IWindowService
    {
        event EventHandler<Size> Resized;

        Task<Size> GetSizeAsync();
    }
}
