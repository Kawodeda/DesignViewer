using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorExtensions.Rendering.Exceptions
{
    public class ContextNotSetException : Exception
    {
        public ContextNotSetException(string? message = null) : base(message) { }
    }
}
