using BlazorExtensions.Commands.Context;
using Model.Design;

namespace BlazorExtensions.Commands
{
    public class ChangeSelectionCommand : ICommand
    {
        Element? _selected;

        public ChangeSelectionCommand(Element? selected)
        {
            _selected = selected;
        }

        public bool CanExecute()
        {
            return true;
        }

        public void Execute(IExecutionContext context)
        {
            context.DesignViewer.SelectedElement = _selected;
        }
    }
}
