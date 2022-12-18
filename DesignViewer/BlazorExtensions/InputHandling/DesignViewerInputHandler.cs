namespace BlazorExtensions.InputHandling
{
    public class DesignViewerInputHandler : BaseInputHandler, IInputHandlingBuilder
    {
        private IDesignViewer _designViewer;

        public DesignViewerInputHandler(IDesignViewer designViewer)
        {
            _designViewer = designViewer;
        }

        public void UseHandler<T>() where T : BaseInputHandler
        {
            Next = (T?)Activator.CreateInstance(typeof(T), new object[] { _designViewer});
        }
    }
}
