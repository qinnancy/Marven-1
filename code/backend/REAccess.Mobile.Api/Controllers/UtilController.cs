#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using REAccess.Mobile.Common.Interfaces;
using REAccess.Mobile.Common.ViewModel;
using static REAccess.Mobile.Common.Constants;
#endregion

namespace REAccess.Mobile.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilController : BaseController
    {
        private readonly ILogger<UtilController> _logger;
        public readonly IUtilService _utilService;

        public UtilController(ILogger<UtilController> logger, IUtilService utilService)
        {
            _logger = logger;
            _utilService = utilService;
        }

        /// <summary>
        /// 获取所有三级指标
        /// </summary>
        [HttpGet("GetAllIndex")]
        public JsonResult GetAllIndex()
        {
            try
            {
                _logger.LogInformation("Start executing GetAllIndex() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseStatusMessage.Success,
                        ReturnObj = _utilService.GetAllIndex()
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetAllIndex() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Exception,
                        StatusMessage = ResponseStatusMessage.Failed,
                        ReturnObj = e.Message
                    });
            }
        }

        /// <summary>
        /// 获取城市列表
        /// </summary>
        [HttpGet("GetCityList")]
        public JsonResult GetCityList()
        {
            try
            {
                _logger.LogInformation("Start executing GetCityList() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseStatusMessage.Success,
                        ReturnObj = _utilService.GetCityList()
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetCityList() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Exception,
                        StatusMessage = ResponseStatusMessage.Failed,
                        ReturnObj = e.Message
                    });
            }
        }
    }
}
