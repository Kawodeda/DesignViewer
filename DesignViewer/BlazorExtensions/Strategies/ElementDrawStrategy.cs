using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aurigma.Design;
using Blazor.Extensions.Canvas.Canvas2D;

namespace BlazorExtensions.Strategies
{
    internal abstract class ElementDrawStrategy:IElementDrawStrategy
    {
        protected Element element;

        protected ElementDrawStrategy(Element element)
        {
            this.element = element;
        }

        public abstract Task Draw(Canvas2DContext context);
    }
}
