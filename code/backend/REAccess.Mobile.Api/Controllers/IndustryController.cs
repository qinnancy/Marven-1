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
    public class IndustryController : BaseController
    {
        private readonly IIndustryService _industryService;
        private readonly ILogger<IndustryController> _logger;
        public IndustryController(IIndustryService industryService, ILogger<IndustryController> logger)
        {
            _industryService = industryService;
            _logger = logger;
        }

        /// <summary>
        /// 产业投资--企业投资--活跃区域
        /// 筛选规则：全部产业/投资项目数量/全国/最新年份的排名
        /// </summary>
        [HttpGet("GetActiveAreaRank")]
        public JsonResult GetActiveAreaRank(int dataCount)
        {
            try
            {
                _logger.LogInformation("Start executing GetActiveAreaRank() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseStatusMessage.Success,
                        ReturnObj = _industryService.GetActiveAreaRank(dataCount)
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetActiveAreaRank() method");
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
        ///产业投资--企业投资--热点产业
        ///筛选规则：全国/投资项目数量/国民经济行业门类/最新年份的排名
        /// </summary>
        [HttpGet("GetHotIndustryRank")]
        public JsonResult GetHotIndustryRank(int dataCount)
        {
            try
            {
                _logger.LogInformation("Start executing GetHotIndustryRank() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseStatusMessage.Success,
                        ReturnObj = _industryService.GetHotIndustryRank(dataCount)
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetHotIndustryRank() method");
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
        ///产业投资-产业用地-活跃区域
        ///筛选条件：全部产业/土地成交笔数/全国/最新年份
        /// </summary>
        [HttpGet("GetIndusrtyActiveRegion")]
        public JsonResult GetIndusrtyActiveRegion(int dataCount)
        {
            try
            {
                _logger.LogInformation("Start executing GetIndusrtyActiveRegion() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseStatusMessage.Success,
                        ReturnObj = _industryService.GetIndusrtyActiveRegion(dataCount)
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetIndusrtyActiveRegion() method");
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
        ///产业投资-产业用地-看热点产业
        ///筛选规则：全国/土地成交笔数/国民经济行业门类/最新年份的排名
        /// </summary>
        [HttpGet("GetLandHotIndustryRank")]
        public JsonResult GetLandHotIndustryRank(int dataCount)
        {
            try
            {
                _logger.LogInformation("Start executing GetLandHotIndustryRank() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseStatusMessage.Success,
                        ReturnObj = _industryService.GetLandHotIndustryRank(dataCount)
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetLandHotIndustryRank() method");
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
        /// 获取项目信息
        /// </summary>
        [HttpGet("GetIndustryProject")]
        public JsonResult GetIndustryProject(string primaryCategory, string secondaryCategory, string currentId,int dataCount)
        {
            try
            {
                _logger.LogInformation("Start executing GetIndustryProject() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseStatusMessage.Success,
                        ReturnObj = _industryService.GetIndustryProject(primaryCategory, secondaryCategory, currentId, dataCount)
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetIndustryProject() method");
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
