#region Using
using Castle.Core;
using Castle.Core.Interceptor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using REAccess.Mobile.Api.Controllers.Attributes;
using REAccess.Mobile.Common.ViewModel;
using REAccess.Mobile.Database.LogModels;
using Serilog;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
#endregion

namespace REAccess.Mobile.Api.Controllers
{
    [ServiceFilter(typeof(LoggingExceptionFilterAttribute))]
    public class BaseController : Controller
    {
        public string RequestIp { get; set; }
        public string RequestUrl { get; set; }
        public string SessionId { get; set; }
        public string PageName { get; set; }
        public string PreviousPage { get; set; }
        public string ParamsInfo { get; set; }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            #region 获取url
            var currentUrl = filterContext.HttpContext.Request.GetDisplayUrl();
            var rawUrl = WebUtility.UrlDecode(filterContext.HttpContext.Request.GetEncodedPathAndQuery());
            RequestUrl = WebUtility.UrlDecode(currentUrl);
            #endregion

            #region 获取用户IP地址
            var currentIp = filterContext.HttpContext.Request.Headers["X-Forwarded-For"].FirstOrDefault();
            if (string.IsNullOrEmpty(currentIp))
            {
                currentIp = filterContext.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString() + ":" + filterContext.HttpContext.Connection.RemotePort;
            }
            RequestIp = currentIp;
            #endregion

            #region 获取session id
            if (filterContext.HttpContext.Session != null)
            {
                SessionId = filterContext.HttpContext.Session.Id;
            }
            #endregion

            #region 获取地址栏参数
            var query = filterContext.HttpContext.Request.Query.ToList();
            if(query.Count() > 0)
            {
                foreach(var param in query)
                {
                    if(param.Key == "PageName")
                    {
                        PageName = param.Value;
                    }
                    else if(param.Key == "PreviousPage")
                    {
                        PreviousPage = param.Value;
                    }
                    ParamsInfo += "(Key: " + param.Key + ")" + "(Value: " + param.Value + ")";
                }
            }
            #endregion

            #region 获取接口返回结果
            GeneralResponse jsonResult = new GeneralResponse();
            if (filterContext.Result != null)
            {
                var result = filterContext.Result as JsonResult;
                if (filterContext.Result is JsonResult)
                {
                    var json = JsonConvert.SerializeObject(result.Value);
                    jsonResult = JsonConvert.DeserializeObject<GeneralResponse>(json);
                }
                else
                {
                    throw new Exception($"未经处理的Result类型:{ filterContext.Result.GetType().Name}");
                }
            }
            #endregion

            #region 获取SectionName
            string sectionName = string.Empty;
            var action = filterContext.RouteData.Values["action"].ToString().ToLower();
            if (action.Contains("industry"))
            {
                sectionName = "Industry";
            }else if (action.Contains("policy"))
            {
                sectionName = "Policy";
            }else if (action.Contains("singleindex"))
            {
                sectionName = "SingleIndex";
            }else if (action.Contains("cityrank"))
            {
                sectionName = "CityRank";
            }
            #endregion

            #region 记录log
            using (LogDatabaseContext db = new LogDatabaseContext())
            {
                ReaMobileSysLog sysLog = new ReaMobileSysLog()
                {
                    Entered = DateTime.Now,
                    Url = RequestUrl,
                    RawUrl = rawUrl,
                    StackTrace = GetStackTraceModelName(),
                    SessionId = SessionId,
                    CityIndexPolicyIndustryParamName = WebUtility.UrlDecode(filterContext.HttpContext.Request.QueryString.ToString()),
                    IpDetail = RequestIp,
                    BrowseType = filterContext.HttpContext.Request.Headers["User-Agent"],
                    PageName = PageName,
                    SectionName = string.IsNullOrEmpty(sectionName) ? PageName : sectionName,
                    PreviousPage = PreviousPage,
                    Description = ParamsInfo,
                    Message = jsonResult.StatusMessage
                };
                db.Add(sysLog);
                db.SaveChanges();
            }
            #endregion
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
