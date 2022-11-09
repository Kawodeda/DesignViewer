using BlazorExtensions.Commands.Context;
using BlazorExtensions.Commands.Parameters;

namespace BlazorExtensions.Commands
{
    public class ScrollCommand : ICommand
    {
        private ScrollCommandParams _params;

        public ScrollCommand(ScrollCommandParams @params)
        {
            _params = @params;
        }

        public bool CanExecute()
        {
            return true;
        }

        public void Execute(IExecutionContext context)
        {
            context.Viewport.ScrollX += _params.DeltaScrollX;
            context.Viewport.ScrollY += _params.DeltaScrollY;
        }
    }
}
