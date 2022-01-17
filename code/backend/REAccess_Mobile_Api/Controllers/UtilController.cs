using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using REAccess_Mobile_Api.Interfaces;
using REAccess_Mobile_Commen.ViewModel;
using static REAccess_Mobile_Commen.Constants;

namespace REAccess_Mobile_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilController : ControllerBase
    {
        private readonly ILogger<UtilController> _logger;
        public readonly IUtilService _utilService;

        public UtilController(ILogger<UtilController> logger, IUtilService utilService)
        {
            _logger = logger;
            _utilService = utilService;
        }

        //获取所有三级指标
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
                        StatusMessage = ResponseMessage.Success,
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
                        StatusMessage = ResponseMessage.Failed,
                        ReturnObj = e.Message
                    });
            }
        }

        //获取城市列表
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
                        StatusMessage = ResponseMessage.Success,
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
                        StatusMessage = ResponseMessage.Failed,
                        ReturnObj = e.Message
                    });
            }
        }

    }
}
