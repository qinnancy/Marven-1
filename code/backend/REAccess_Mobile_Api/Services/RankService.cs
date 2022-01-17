using REAccess_Mobile_Api.Interfaces;
using REAccess_Mobile_Api.Utils;
using REAccess_Mobile_Common.ViewModel;
using REAccess_Mobile_Database;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace REAccess_Mobile_Api.Services
{
    public class RankService : ServiceBase, IRankService
    {
        private readonly IUtilService _utilService;
        public RankService(IUtilService utilService)
        {
            _utilService = utilService;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        //单指标排名
        public SingleIndexModel GetSingleIndexRank(string selectIndex,string selectYear)
        {
            SingleIndexModel model = new SingleIndexModel();
            List<RankModel> singleIndexList = new List<RankModel>();
            var indicatorOriginalScore = StaticCache.IndicatorOriginalScore;
            var districtList = StaticCache.Districts;
            if (string.IsNullOrEmpty(selectYear))
            {
                selectYear = StaticCache.IndicatorOriginalScore.Max(x => x.SnapshotPeriod);
            }
            foreach(var district in districtList)
            {
                var indicator = indicatorOriginalScore.FirstOrDefault(x => x.DistrictSk == district.DistrictSk && x.SnapshotPeriod == selectYear);
                if(indicator != null)
                {
                    RankModel singleIndex = new RankModel()
                    {
                        DistrictSk = district.DistrictSk,
                        CityName = district.CityName,
                        ProvinceName = district.ProvName,
                        RankValue = ((decimal)indicator.GetOriginalValueByName(selectIndex)).ToString("N0")
                    };
                    singleIndexList.Add(singleIndex);
                }
            }
            singleIndexList = singleIndexList.OrderByDescending(x => float.Parse(x.RankValue)).Take(5).ToList();
            //根据指标数据排名--数据相同则名次相同
            for (var i = 0; i < singleIndexList.Count(); i++)
            {
                if (i == 0)
                {
                    singleIndexList[i].RankPlace = 1;
                }
                else
                {
                    if (singleIndexList[i].RankValue == singleIndexList[i - 1].RankValue)
                    {
                        singleIndexList[i].RankPlace = singleIndexList[i - 1].RankPlace;
                    }
                    else
                    {
                        singleIndexList[i].RankPlace = i + 1;
                    }
                }
            }
            model.SingleIndexList = singleIndexList;
            model.Unit = StaticCache.Indicators.FirstOrDefault(x => x.Name == selectIndex).DisplayDataUnit;

            return model;
        }

        //城市排名
        public CityRankModel GetCityRank(string selectCity, string selectYear)
        {
            CityRankModel model = new CityRankModel();
            List<CityRank> cityRankList = new List<CityRank>();
            //筛选时间默认为最新时间
            if (string.IsNullOrEmpty(selectYear))
            {
                selectYear = StaticCache.IndicatorOriginalScore.Max(x => x.SnapshotPeriod);
            }
            model.Year = selectYear;
            //获取指标列表
            var indicatorList = _utilService.GetAllIndex();
            //获取已选城市ID
            var districtSk = StaticCache.Districts.FirstOrDefault(x => x.CityName == selectCity && x.CityName == x.DistrictName).DistrictSk;
            //获取指标得分表
            var indicatorScore = StaticCache.IndicatorScore.FirstOrDefault(x => x.DistrictSk == districtSk && x.SnapshotPeriod == selectYear);
            foreach(var indicator in indicatorList)
            {
                CityRank cityRank = new CityRank()
                {
                    IndexName = indicator,
                    IndexValue = ((double)indicatorScore.GetValueByName(indicator)).ToString("0.00")
                };
                cityRankList.Add(cityRank);
            }
            cityRankList = cityRankList.OrderByDescending(x => float.Parse(x.IndexValue)).Take(5).ToList();
            //根据指标得分排名--得分相同则名次相同
            for (var i = 0; i < cityRankList.Count(); i++)
            {
                if (i == 0)
                {
                    cityRankList[i].RankPlace = 1;
                }
                else
                {
                    if (cityRankList[i].IndexValue == cityRankList[i - 1].IndexValue)
                    {
                        cityRankList[i].RankPlace = cityRankList[i - 1].RankPlace;
                    }
                    else
                    {
                        cityRankList[i].RankPlace = i + 1;
                    }
                }
            }
            model.CityRankList = cityRankList;

            return model;
        }
        
        //咨询
        public List<NewsModel> GetNewsList()
        {
            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.ShortDatePattern = "yyyy-MM-dd";
            List<NewsModel> model = StaticCache.DdsNews.Select(x => new NewsModel()
            {
                NewsTitle = x.Title,
                NewsContent = x.Content,
                NewsReleaseDate = Convert.ToDateTime(x.ReleaseTime,dtFormat).ToString("yyyy-MM-dd"),
                NewTags = x.Tags.Split(';').ToList()
            }).ToList();

            return model;
        }
    }
}
