using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.Net;
using Teste.Back.End.Correios.Api.DTO.Error;

namespace Teste.Back.End.Correios.Api.Infra.Filters
{
    /// <summary>
    /// ExceptionFilter
    /// </summary>
    public class ExceptionFilter : IExceptionFilter
    {

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="logger"></param>
        public ExceptionFilter()
        {
        }


        /// <summary>
        /// OnException
        /// </summary>
        /// <param name="context"></param>
        public void OnException(ExceptionContext context)
        {
            context.HttpContext.Response.ContentType = "application/json";
            var httpStatusCode = HttpStatusCode.InternalServerError;
            IActionResult result = null;


            if (result == null)
                result = new JsonResult(new ErrorDescription(context.Exception.Message));

            context.Result = result;
            context.HttpContext.Response.StatusCode = (int)httpStatusCode;
        }
    }
}
