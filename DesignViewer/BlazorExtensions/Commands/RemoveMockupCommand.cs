using BlazorExtensions.Commands.Context;

namespace BlazorExtensions.Commands
{
    public class RemoveMockupCommand : ICommand
    {
        public bool CanExecute()
        {
            return true;
        }

        public void Execute(IExecutionContext context)
        {
            context.DesignViewer.CurrentSurface.Mockup = null;
        }
    }
}
