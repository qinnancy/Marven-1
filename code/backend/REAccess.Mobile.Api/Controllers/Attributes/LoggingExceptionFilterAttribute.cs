#region Using
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using REAccess.Mobile.Common;
using REAccess.Mobile.Common.ViewModel;
using Serilog;
#endregion

namespace REAccess.Mobile.Api.Controllers.Attributes
{
    public class LoggingExceptionFilterAttribute : ExceptionFilterAttribute
    {
        private IHostingEnvironment HostingEnvironment { get; }
        private IModelMetadataProvider ModelMetadataProvider { get; }
        public override void OnException(ExceptionContext context)
        {
            if (context.ActionDescriptor is ControllerActionDescriptor actionDescriptor)
            {
                Log.Error(context.Exception, "Unhandled exception captured.");
            }

            var response = new GeneralResponse
            {
                StatusCode = Constants.ResponseStatusCode.Error,
                StatusMessage = HostingEnvironment.IsDevelopment() ? context.Exception.ToString() : context.Exception.Message
                //StatusMessage = context.Exception.StackTrace
            };
            context.Result = new JsonResult(response);

        }
    }
}
