using BlazorExtensions.Commands.Context;

namespace BlazorExtensions.Commands
{
    public class EmptyCommand : ICommand
    {
        public bool CanExecute()
        {
            return false;
        }

        public void Execute(IExecutionContext context)
        {
            return;
        }
    }
}
