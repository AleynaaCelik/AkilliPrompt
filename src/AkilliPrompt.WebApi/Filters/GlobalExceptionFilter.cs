using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using AkilliPrompt.WebApi.Helpers;
using AkilliPrompt.WebApi.Models;

namespace AkilliPrompt.WebApi.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<GlobalExceptionFilter> _logger;

        public GlobalExceptionFilter(ILogger<GlobalExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            _logger.LogError(context.Exception, context.Exception.Message);

            context.ExceptionHandled = true;

            if (context.Exception is ValidationException validationException)
            {
                var responseMessage = MessageHelper.GeneralValidationErrorMessage;

                var errors = validationException.Errors
                    .GroupBy(e => e.PropertyName)
                    .Select(g => new ValidationError(g.Key, g.Select(e => e.ErrorMessage)))
                    .ToList();

                context.Result = new BadRequestObjectResult(ResponseDto<object>.Error(responseMessage, errors))
                {
                    StatusCode = StatusCodes.Status400BadRequest
                };
            }
            else
            {
                context.Result = new ObjectResult(ResponseDto<object>.Error(MessageHelper.GeneralErrorMessage))
                {
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }
        }
    }
}
