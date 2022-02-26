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
using static REAccess.Mobile.Common.Constants;
#endregion

namespace REAccess.Mobile.Api.Controllers
{
    [ServiceFilter(typeof(LoggingExceptionFilterAttribute))]
    public class BaseController : Controller
    {
        public string RequestIp { get; set; }
        public string RequestUrl { get; set; }
        public string SessionId { get; set; }
        public string ParamsInfo { get; set; }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            try
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
                object pageName = null;
                object previousPage = null;
                var routeData = filterContext.RouteData.Values;
                if (routeData.ContainsKey("pageName"))
                {
                    routeData.TryGetValue("pageName", out pageName);
                }
                if (routeData.ContainsKey("previousPage"))
                {
                    routeData.TryGetValue("previousPage", out previousPage);
                }
                var query = filterContext.HttpContext.Request.Query.ToList();
                if (query.Count() > 0)
                {
                    foreach (var param in query)
                    {
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
                if (action.ToLower().Contains("industry"))
                {
                    sectionName = "产业";
                }
                else if (action.ToLower().Contains("policy"))
                {
                    sectionName = "政策";
                }
                else if (action.ToLower().Contains("singleindex"))
                {
                    sectionName = "单项排名";
                }
                else if (action.ToLower().Contains("cityrank"))
                {
                    sectionName = "城市排名";
                }
                else if (action.ToLower().Contains("news"))
                {
                    sectionName = "资讯";
                }
                #endregion

                #region 记录log            
                using (LogDatabaseContext db = new LogDatabaseContext())
                {
                    ReaMobileSysLog sysLog = new ReaMobileSysLog()
                    {
                        Entered = DateTime.Now,
                        Url = string.IsNullOrEmpty(RequestUrl) ? string.Empty : RequestUrl,
                        RawUrl = string.IsNullOrEmpty(rawUrl) ? string.Empty : rawUrl,
                        StackTrace = GetStackTraceModelName(),
                        SessionId = SessionId,
                        CityIndexPolicyIndustryParamName = WebUtility.UrlDecode(filterContext.HttpContext.Request.QueryString.ToString()),
                        IpDetail = RequestIp,
                        BrowseType = filterContext.HttpContext.Request.Headers["User-Agent"],
                        PageName = pageName == null ? "" : pageName.ToString(),
                        SectionName = string.IsNullOrEmpty(sectionName) ? (pageName == null ? "" : pageName.ToString()) : sectionName,
                        PreviousPage = previousPage == null? "" : previousPage.ToString(),
                        Description = ParamsInfo,
                        Message = jsonResult.StatusMessage == ResponseStatusMessage.Success ? jsonResult.StatusMessage : jsonResult.ReturnObj == null ? ResponseStatusMessage.Failed : ResponseStatusMessage.Failed + ": " + jsonResult.ReturnObj.ToString()
                    };
                    db.Add(sysLog);
                    db.SaveChanges();
                }
                #endregion
            }
            catch (Exception e)
            {
                Log.Error(e.Message,"ControllerBase Error");
                Log.Error(e.InnerException,"ControllerBase Error");
                throw new Exception(e.Message, e);
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
