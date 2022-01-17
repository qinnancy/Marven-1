using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using REAccess_Mobile_Api.Interfaces;
using REAccess_Mobile_Common.ViewModel;
using static REAccess_Mobile_Common.Constants;

namespace REAccess_Mobile_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndustryController : ControllerBase
    {
        private readonly IIndustryService _industryService;
        private readonly ILogger<IndustryController> _logger;
        public IndustryController(IIndustryService industryService, ILogger<IndustryController> logger)
        {
            _industryService = industryService;
            _logger = logger;
        }

        //产业投资--企业投资--活跃区域
        [HttpGet("GetActiveAreaRank")]
        public JsonResult GetActiveAreaRank()
        {
            try
            {
                _logger.LogInformation("Start executing GetActiveAreaRank() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseMessage.Success,
                        ReturnObj = _industryService.GetActiveAreaRank()
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetActiveAreaRank() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Exception,
                        StatusMessage = ResponseMessage.Failed,
                        ReturnObj = e.Message
                    });
            }
        }
        //产业投资--企业投资--热点产业
        [HttpGet("GetHotIndustryRank")]
        public JsonResult GetHotIndustryRank()
        {
            try
            {
                _logger.LogInformation("Start executing GetHotIndustryRank() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseMessage.Success,
                        ReturnObj = _industryService.GetHotIndustryRank()
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetHotIndustryRank() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Exception,
                        StatusMessage = ResponseMessage.Failed,
                        ReturnObj = e.Message
                    });
            }
        }
        //产业投资--企业投资--活跃区域
        [HttpGet("GetIndusrtyActiveRegion")]
        public JsonResult GetIndusrtyActiveRegion()
        {
            try
            {
                _logger.LogInformation("Start executing GetIndusrtyActiveRegion() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseMessage.Success,
                        ReturnObj = _industryService.GetIndusrtyActiveRegion()
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetIndusrtyActiveRegion() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Exception,
                        StatusMessage = ResponseMessage.Failed,
                        ReturnObj = e.Message
                    });
            }
        }
        //产业投资--企业投资--看热点产业
        [HttpGet("GetLandHotIndustryRank")]
        public JsonResult GetLandHotIndustryRank()
        {
            try
            {
                _logger.LogInformation("Start executing GetLandHotIndustryRank() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseMessage.Success,
                        ReturnObj = _industryService.GetLandHotIndustryRank()
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetLandHotIndustryRank() method");
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
