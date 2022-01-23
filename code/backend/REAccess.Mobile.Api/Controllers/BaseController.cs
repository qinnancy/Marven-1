#region Using
using Castle.Core.Interceptor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using REAccess.Mobile.Api.Controllers.Attributes;
using Serilog;
using System;
using System.Linq;
#endregion

namespace REAccess.Mobile.Api.Controllers
{
    [ServiceFilter(typeof(LoggingExceptionFilterAttribute))]
    public class BaseController : Controller
    {
        public string RequestIp { get; set; }
        public string RequestUrl { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var currentUrl = filterContext.HttpContext.Request.GetDisplayUrl();
            var currentIp = filterContext.HttpContext.Request.Headers["X-Forwarded-For"].FirstOrDefault();
            if (string.IsNullOrEmpty(currentIp))
            {
                currentIp = filterContext.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString() + ":" + filterContext.HttpContext.Connection.RemotePort;
            }
            RequestIp = currentIp;
            RequestUrl = currentUrl;
        }

    }
}
