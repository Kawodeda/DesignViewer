﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace DesignViewer.Server.Filters
{
    public class DesignsExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.ExceptionHandled = true;
        }
    }
}
