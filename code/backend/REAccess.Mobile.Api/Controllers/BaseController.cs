#region Using
using Castle.Core.Interceptor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using REAccess.Mobile.Api.Controllers.Attributes;
using REAccess.Mobile.Database.LogModels;
using Serilog;
using System;
using System.Diagnostics;
using System.Linq;
#endregion

namespace REAccess.Mobile.Api.Controllers
{
    [ServiceFilter(typeof(LoggingExceptionFilterAttribute))]
    public class BaseController : Controller
    {
        public string RequestIp { get; set; }
        public string RequestUrl { get; set; }
        public string SessionId { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string requestData = string.Empty;

            //获取url
            var currentUrl = filterContext.HttpContext.Request.GetDisplayUrl();
            var rawUrl = filterContext.HttpContext.Request.GetEncodedPathAndQuery();
            RequestUrl = currentUrl;
            //获取用户IP地址
            var currentIp = filterContext.HttpContext.Request.Headers["X-Forwarded-For"].FirstOrDefault();
            if (string.IsNullOrEmpty(currentIp))
            {
                currentIp = filterContext.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString() + ":" + filterContext.HttpContext.Connection.RemotePort;
            }
            RequestIp = currentIp;

            //获取session id
            if(filterContext.HttpContext.Session != null)
            {
                SessionId = filterContext.HttpContext.Session.Id;
            }
            string paramInfo = string.Empty;

            //获取地址栏参数
            if (filterContext.ActionArguments.Count() > 0)
            {
                var paramsList = filterContext.ActionArguments;
                for(var i = 0; i < paramsList.Count(); i++)
                {
                }
                requestData = JsonConvert.SerializeObject(filterContext.ActionArguments);
            }
            else
            {
                requestData = JsonConvert.SerializeObject(filterContext.HttpContext.Request.QueryString.ToString());
            }
            using (LogDatabaseContext db = new LogDatabaseContext())
            {
                ReaMobileSysLog sysLog = new ReaMobileSysLog()
                {
                    Entered = DateTime.Now,
                    Url = RequestUrl,
                    RawUrl = rawUrl,
                    StackTrace = GetStackTraceModelName(),
                    SessionId = SessionId,
                    CityIndexPolicyIndustryParamName = requestData,
                    IpDetail = RequestIp,
                    BrowseType = filterContext.HttpContext.Request.Headers["User-Agent"],
                    PageName = "",
                    SectionName = "",
                    PreviousPage = "",
                    Description = "",
                    Message = ""
                };
            }
        }

        /// <summary>
        /// 获取堆栈
        /// </summary>
        /// <returns></returns>
        public static string GetStackTraceModelName()
        {
            //当前堆栈信息
            StackTrace st = new StackTrace();
            StackFrame[] sfs = st.GetFrames();
            //过滤的方法名称，以下方法将不会出现在返回的方法调用列表中
            string fullName = string.Empty;
            string methodName = string.Empty;
            for(var i = 1; i < sfs.Length; ++i)
            {
                //非用户代码,系统方法及后面的都是系统调用，不获取用户代码调用结束
                if(StackFrame.OFFSET_UNKNOWN == sfs[i].GetILOffset())
                {
                    break;
                }
                var methodInfo = sfs[i].GetMethod();
                methodName = methodInfo.ReflectedType.FullName + "." + methodInfo.Name;//方法名称

                fullName = methodName + "()\r\n->" + fullName;
            }
            st = null;
            sfs = null;

            return fullName.TrimEnd('-','>');

        }


    }
}
