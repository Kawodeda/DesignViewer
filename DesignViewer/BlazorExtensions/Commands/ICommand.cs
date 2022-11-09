using BlazorExtensions.Commands.Context;

namespace BlazorExtensions.Commands
{
    public interface ICommand
    {
        public void Execute(IExecutionContext context);

        public bool CanExecute();

        public static ICommand operator +(ICommand a, ICommand b)
        {
            return new CompositeCommand(a, b);
        }
    }
}
