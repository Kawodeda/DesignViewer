using BlazorExtensions.Commands.Context;

namespace BlazorExtensions.Commands
{
    public class CompositeCommand : ICommand
    {
        private readonly List<ICommand> _commands;

        public CompositeCommand(params ICommand[] commands)
        {
            _commands = new List<ICommand>(commands);
        }

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public bool CanExecute()
        {
            return true;
        }

        public void Execute(IExecutionContext context)
        {
            foreach (ICommand command in _commands)
            {
                if (command.CanExecute())
                {
                    command.Execute(context);
                }
            }
        }
    }
}
