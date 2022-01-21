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
        /// <param name="dataCount">数据条数，可不传参，默认为5条</param>
        /// <returns></returns>
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
        /// <param name="dataCount">数据条数，可不传参，默认为5条</param>
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
        ///<param name="dataCount">数据条数，可不传参，默认为5条</param>
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
        ///<param name="dataCount">数据条数，可不传参，默认为5条</param>
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
        /// <param name="primaryCategory">参数：企业投资/产业用地</param>
        /// <param name="secondaryCategory">参数：活跃区域/热点产业</param>
        /// <param name="currentId">当前城市/产业的Id</param>
        /// <param name="dataCount">数据条数，可不传参，默认为8条</param>
        /// <returns></returns>
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

        /// <summary>
        /// 获取政策数据
        /// </summary>
        /// <param name="industryId">产业分类Id</param>
        /// <param name="policyCategory">数据分类（政策类/规划类）可不传参</param>
        /// <param name="dataCount">数据条数，默认10条，可不传参</param>
        /// <returns></returns>
        [HttpGet("GetPolicyData")]
        public JsonResult GetPolicyData(int industryId, string policyCategory, int dataCount)
        {
            try
            {
                _logger.LogInformation("Start executing GetPolicyData() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseStatusMessage.Success,
                        ReturnObj = _industryService.GetPolicyData(industryId, policyCategory, dataCount)
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetPolicyData() method");
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
        /// 获取政策文件详细信息
        /// </summary>
        /// <param name="policyId">政策文件Id</param>
        /// <returns></returns>
        [HttpGet("GetPolicyDetail")]
        public JsonResult GetPolicyDetail(int policyId)
        {
            try
            {
                _logger.LogInformation("Start executing GetPolicyDetail() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseStatusMessage.Success,
                        ReturnObj = _industryService.GetPolicyDetail(policyId)
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetPolicyDetail() method");
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
