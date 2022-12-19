using BlazorExtensions.Commands.Context;
using BlazorExtensions.Commands.Parameters;

namespace BlazorExtensions.Commands
{
    public class ResizeElementCommand : ICommand
    {
        private ResizeElementCommandParams _params;

        public ResizeElementCommand(ResizeElementCommandParams @params) 
        {
            _params = @params;
        }

        public bool CanExecute()
        {
            return true;
        }

        public void Execute(IExecutionContext context)
        {
            _params.Element.Transform = _params.Element.Transform.Scale(_params.ScaleX, _params.ScaleY);
        }
    }
}
