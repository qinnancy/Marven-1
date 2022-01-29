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
    public class RankController : BaseController
    {
        private readonly IRankService _rankService;
        private readonly ILogger<RankController> _logger;

        public RankController(IRankService rankService, ILogger<RankController> logger)
        {
            _rankService = rankService;
            _logger = logger;
        }

        /// <summary>
        /// 单指标排名，根据用户选择的指标获取该指标的真实数据进行排名，取排名前N的数据
        /// </summary>
        /// <param name="selectIndex">已选指标</param>
        /// <param name="selectYear">已选年份,可不传参，默认最新年份</param>
        /// <param name="dataCount">数据条数,可不传参，默认5条</param>
        /// <returns></returns>
        [HttpGet("GetSingleIndexRank")]
        public JsonResult GetSingleIndexRank(string selectIndex, string selectYear,int dataCount)
        {
            try
            {
                _logger.LogInformation("Start executing GetSingleIndexRank() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseStatusMessage.Success,
                        ReturnObj = _rankService.GetSingleIndexRank(selectIndex, selectYear, dataCount)
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetSingleIndexRank() method");
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
        /// 城市排名,根据用户选择的城市，获取该城市的每一个指标在所有城市中的排名，并取出排名前N的数据
        /// </summary>
        /// <param name="selectCity">已选城市</param>
        /// <param name="selectYear">已选年份,可不传参，默认最新年份</param>
        /// <param name="dataCount">数据条数,可不传参，默认5条</param>
        /// <returns></returns>
        [HttpGet("GetCityRank")]
        public JsonResult GetCityRank(string selectCity, string selectYear, int dataCount)
        {
            try
            {
                _logger.LogInformation("Start executing GetCityRank() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseStatusMessage.Success,
                        ReturnObj = _rankService.GetCityRank(selectCity, selectYear, dataCount)
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetCityRank() method");
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
        /// 获取资讯信息
        /// </summary>
        /// <param name="currentPage">当前页数</param>
        /// <param name="pageSize">每页显示个数</param>
        /// <returns></returns>
        [HttpGet("GetNewsList")]
        public JsonResult GetNewsList(int currentPage, int pageSize)
        {
            try
            {
                _logger.LogInformation("Start executing GetNewsList() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseStatusMessage.Success,
                        ReturnObj = _rankService.GetNewsList(currentPage,pageSize)
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetNewsList() method");
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
        /// 获取资讯详细信息
        /// </summary>
        /// <param name="newsId">资讯Id</param>
        /// <returns></returns>
        [HttpGet("GetNewsById")]
        public JsonResult GetNewsById(int newsId)
        {
            try
            {
                _logger.LogInformation("Start executing GetNewsById() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseStatusMessage.Success,
                        ReturnObj = _rankService.GetNewsById(newsId)
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetNewsById() method");
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
