using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using Utils.Exceptions;

namespace Utils.Filters
{
    public class HttpExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var error = new HttpException(
                "Interval Server Error",
                HttpStatusCode.InternalServerError);

            context.HttpContext.Response.StatusCode = 500;

            if (context.Exception is HttpException)
            {
                error = context.Exception as HttpException;
                if (error != null)
                {
                    context.HttpContext.Response.StatusCode = (int)error.ErrorCode;
                }
            }

            if (context.Exception.InnerException is HttpException)
            {
                error = context.Exception.InnerException as HttpException;
                if (error != null)
                {
                    context.HttpContext.Response.StatusCode = (int)error.ErrorCode;
                }
            }

            context.Result = new JsonResult(new { error = error != null ? error.Message : "Internal Server Error" });
            base.OnException(context);
        }
    }
}
