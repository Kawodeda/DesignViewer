using Blazor.Extensions.Canvas.Canvas2D;

namespace BlazorExtensions.Rendering
{
    public abstract class BaseRenderer
    {
        protected const string ContextNotSetMessage = "Rendering context was not set";

        protected Canvas2DContext? _context;

        public virtual Canvas2DContext? Context
        {
            get
            {
                return _context;
            }
            set
            {
                _context = value;
            }
        }
    }
}
