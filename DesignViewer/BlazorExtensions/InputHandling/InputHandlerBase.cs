using BlazorExtensions.Commands;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorExtensions.InputHandling
{
    public abstract class InputHandlerBase : IInputHandler
    {
        private IInputHandler? _next;

        public IInputHandler? Next 
        { 
            get
            {
                return _next;
            }
            set
            {
                if (_next == null)
                {
                    _next = value;
                    return;
                }

                _next.Next = value;
            }
        }

        public virtual ICommand OnClick(MouseEventArgs e)
        {
            return HandleByDefault(() => Next?.OnClick(e));
        }

        public virtual ICommand OnMouseDown(MouseEventArgs e)
        {
            return HandleByDefault(() => Next?.OnMouseDown(e));
        }

        public virtual ICommand OnMouseMove(MouseEventArgs e)
        {
            return HandleByDefault(() => Next?.OnMouseMove(e));
        }

        public virtual ICommand OnMouseOut(MouseEventArgs e)
        {
            return HandleByDefault(() => Next?.OnMouseOut(e));
        }

        public virtual ICommand OnMouseOver(MouseEventArgs e)
        {
            return HandleByDefault(() => Next?.OnMouseOver(e));
        }

        public virtual ICommand OnMouseUp(MouseEventArgs e)
        {
            return HandleByDefault(() => Next?.OnMouseUp(e));
        }

        public virtual ICommand OnWheel(WheelEventArgs e)
        {
            return HandleByDefault(() => Next?.OnWheel(e));
        }

        public virtual ICommand OnKeyPress(KeyboardEventArgs e)
        {
            return HandleByDefault(() => Next?.OnKeyPress(e));
        }

        public virtual ICommand OnKeyDown(KeyboardEventArgs e)
        {
            return HandleByDefault(() => Next?.OnKeyDown(e));
        }

        public virtual ICommand OnKeyUp(KeyboardEventArgs e)
        {
            return HandleByDefault(() => Next?.OnKeyUp(e));
        }

        protected virtual ICommand HandleByDefault(Func<ICommand?> next) 
        {
            return next?.Invoke() ?? new EmptyCommand();
        }
    }
}
