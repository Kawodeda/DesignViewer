using BlazorExtensions.Commands.Context;
using BlazorExtensions.Commands.Parameters;

namespace BlazorExtensions.Commands
{
    public class TranslateElementCommand : ICommand
    {
        private TranslateElementCommandParams _params;

        public TranslateElementCommand(TranslateElementCommandParams @params)
        {
            _params = @params;
        }

        public bool CanExecute()
        {
            return true;
        }

        public void Execute(IExecutionContext context)
        {
            _params.Element.Position += _params.Shift;
        }
    }
}
