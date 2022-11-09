using Aurigma.Design;
using BlazorExtensions.Commands.Context;

namespace BlazorExtensions.Commands
{
    public class AddElementCommand : ICommand
    {
        private Element _element;

        public AddElementCommand(Element element)
        {
            _element = element;
        }

        public bool CanExecute()
        {
            return true;
        }

        public void Execute(IExecutionContext context)
        {
            context.DesignViewer.CurrentSurface
                .Layers
                .First().Elements
                .Add(_element);
        }
    }
}
