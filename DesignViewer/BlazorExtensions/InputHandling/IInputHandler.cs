using BlazorExtensions.Commands;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorExtensions.InputHandling
{
    public interface IInputHandler
    {
        public IInputHandler? Next { get; set; }

        public ICommand OnMouseDown(MouseEventArgs e);
        
        public ICommand OnMouseMove(MouseEventArgs e);
        
        public ICommand OnMouseUp(MouseEventArgs e);

        public ICommand OnMouseOver(MouseEventArgs e);

        public ICommand OnMouseOut(MouseEventArgs e);

        public ICommand OnWheel(WheelEventArgs e);

        public ICommand OnKeyPress(KeyboardEventArgs e);

        public ICommand OnKeyDown(KeyboardEventArgs e);

        public ICommand OnKeyUp(KeyboardEventArgs e);
    }
}
