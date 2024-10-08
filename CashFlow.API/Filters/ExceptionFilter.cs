using CashFlow.Communication.Responses;
using CashFlow.Exception.BasesException;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CashFlow.API.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is CashFlowException)
            {
                HandleProjectException(context);
            }
            else
            {
                ThrowUnkowError(context);
            }
        }

        private void HandleProjectException(ExceptionContext context)
        {
            if (context.Exception is ErrorOnValidationException)
            {
                var ex = (ErrorOnValidationException)context.Exception;
                var errorsMessage = new ResponseErrorJson(ex.Errors);

                context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Result = new BadRequestObjectResult(errorsMessage);
            }
            else
            {
                var errorsMessage = new ResponseErrorJson(context.Exception.Message);

                context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Result = new BadRequestObjectResult(errorsMessage);
            }
        }

        private void ThrowUnkowError(ExceptionContext context)
        {
            var errorMessage = new ResponseErrorJson("Unknown Error");

            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(errorMessage);
        }
    }
}
