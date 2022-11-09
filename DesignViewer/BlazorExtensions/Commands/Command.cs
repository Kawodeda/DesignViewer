using BlazorExtensions.Commands.Context;

namespace BlazorExtensions.Commands
{
    /// <summary>
    /// The basic implementation of ICommand
    /// </summary>
    public class Command : ICommand
    {
        private Action<IExecutionContext, object?> _execute;
        private Func<object?, bool> _canExecute;
        private IExecutionContext _context;
        private object? _parameter;

        public Command(
            Action<IExecutionContext, object?> execute, 
            Func<object?, bool> canExecute,
            IExecutionContext context,
            object? parameter = null)
        {
            _execute = execute;
            _canExecute = canExecute;
            _context = context;
            _parameter = parameter;
        }

        public void Execute(IExecutionContext context)
        {
            _execute(_context, _parameter);
        }

        public bool CanExecute()
        {
            return _canExecute == null || _canExecute(_parameter);
        }
    }
}
