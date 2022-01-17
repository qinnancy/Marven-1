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
    public class RankController : ControllerBase
    {
        private readonly IRankService _rankService;
        private readonly ILogger<RankController> _logger;

        public RankController(IRankService rankService, ILogger<RankController> logger)
        {
            _rankService = rankService;
            _logger = logger;
        }

        //单指标排名
        [HttpGet("GetSingleIndexRank")]
        public JsonResult GetSingleIndexRank(string selectIndex,string selectYear)
        {
            try
            {
                _logger.LogInformation("Start executing GetSingleIndexRank() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseMessage.Success,
                        ReturnObj = _rankService.GetSingleIndexRank(selectIndex, selectYear)
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetSingleIndexRank() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Exception,
                        StatusMessage = ResponseMessage.Failed,
                        ReturnObj = e.Message
                    });
            }
        }
        //城市排名
        [HttpGet("GetCityRank")]
        public JsonResult GetCityRank(string selectCity,string selectYear)
        {
            try
            {
                _logger.LogInformation("Start executing GetCityRank() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseMessage.Success,
                        ReturnObj = _rankService.GetCityRank(selectCity, selectYear)
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetCityRank() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Exception,
                        StatusMessage = ResponseMessage.Failed,
                        ReturnObj = e.Message
                    });
            }
        }
        //资讯
        [HttpGet("GetNewsList")]
        public JsonResult GetNewsList()
        {
            try
            {
                _logger.LogInformation("Start executing GetNewsList() method");
                return new JsonResult(
                    new GeneralResponse()
                    {
                        StatusCode = ResponseStatusCode.Success,
                        StatusMessage = ResponseMessage.Success,
                        ReturnObj = _rankService.GetNewsList()
                    });
            }
            catch (Exception e)
            {
                _logger.LogInformation(e, "Error in GetNewsList() method");
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
