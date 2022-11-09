using Aurigma.Design;
using BlazorExtensions.Commands.Context;

namespace BlazorExtensions.Commands
{
    public class DeleteElementCommand : ICommand
    {
        private Element _element;

        public DeleteElementCommand(Element element)
        {
            _element = element;
        }

        public bool CanExecute()
        {
            return true;
        }

        public void Execute(IExecutionContext context)
        {
            foreach (var layer in context.DesignViewer.CurrentSurface.Layers)
            {
                foreach (var element in layer.Elements)
                {
                    if (_element == element)
                    {
                        layer.Elements.Remove(element);
                    }
                }
            }
        }
    }
}
