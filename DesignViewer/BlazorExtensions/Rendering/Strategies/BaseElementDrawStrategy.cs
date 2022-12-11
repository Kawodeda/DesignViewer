using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Design;
using Blazor.Extensions.Canvas.Canvas2D;

namespace BlazorExtensions.Rendering.Strategies
{
    internal abstract class BaseElementDrawStrategy : IElementDrawStrategy
    {
        protected Element _element;

        protected BaseElementDrawStrategy(Element element)
        {
            _element = element;
        }

        public abstract Task Draw(Canvas2DContext context);
    }
}
