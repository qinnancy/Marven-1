﻿#region Using
using REAccess.Mobile.Common.Interfaces;
using REAccess.Mobile.Common.ViewModel;
using REAccess.Mobile.Database.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using static REAccess.Mobile.Common.Constants;
#endregion

namespace REAccess.Mobile.Common.Services
{
    public class RankService : BaseService, IRankService
    {
        private readonly IUtilService _utilService;
        public RankService(IUtilService utilService)
        {
            _utilService = utilService;
        }

        ///<summary>
        ///清理所有正在使用的资源
        ///</summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 单指标排名，根据用户选择的指标获取该指标的真实数据进行排名，取排名前N的数据
        /// </summary>
        public SingleIndexModel GetSingleIndexRank(string selectIndex, string selectYear,int dataCount)
        {
            SingleIndexModel model = new SingleIndexModel();
            List<RankModel> singleIndexList = new List<RankModel>();
            //获取数据库所有指标的真实数据
            var indicatorOriginalScore = StaticCache.IndicatorOriginalScore;
            //获取数据库城市列表
            var districtList = StaticCache.Districts;
            if (string.IsNullOrEmpty(selectYear))
            {
                //若年份为空，则取数据库数据的最新年份
                selectYear = StaticCache.IndicatorOriginalScore.Max(x => x.SnapshotPeriod);
            }

            //默认取排名前五的数据
            dataCount = dataCount == 0 ? 5 : dataCount;
            
            foreach (var district in districtList)
            {
                var indicator = indicatorOriginalScore.FirstOrDefault(x => x.DistrictSk == district.DistrictSk && x.SnapshotPeriod == selectYear);
                if (indicator != null)
                {
                    RankModel singleIndex = new RankModel()
                    {
                        DistrictSk = district.DistrictSk,
                        CityName = district.CityName,
                        ProvinceName = district.ProvName,
                        RankValue = ((decimal)indicator.GetOriginalValueByName(selectIndex)).ToString("N0")//通过指标中文名映射数据库字段名，获取该数据的真实值
                    };
                    singleIndexList.Add(singleIndex);
                }
            }

            //根据所有指标真实数据进行倒叙排名，并取出排名前五的数据
            singleIndexList = singleIndexList.OrderByDescending(x => float.Parse(x.RankValue)).Take(dataCount).ToList();

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

        /// <summary>
        /// 城市排名,根据用户选择的城市，获取该城市的每一个指标在所有城市中的排名，并取出排名前N的数据
        /// </summary>
        public CityRankModel GetCityRank(string selectCity, string selectYear,int dataCount)
        {
            CityRankModel model = new CityRankModel();
            List<CityRank> cityRankList = new List<CityRank>();
            //筛选时间默认为最新时间
            if (string.IsNullOrEmpty(selectYear))
            {
                selectYear = StaticCache.IndicatorOriginalScore.Max(x => x.SnapshotPeriod);
            }
            //默认取排名前五的数据
            dataCount = dataCount == 0 ? 5 : dataCount;

            model.Year = selectYear;
            //获取指标列表
            var indicatorList = _utilService.GetAllIndex();
            //获取已选城市ID
            var districtSk = StaticCache.Districts.FirstOrDefault(x => x.CityName == selectCity && x.CityName == x.DistrictName).DistrictSk;
            //获取指标得分表
            var indicatorScore = StaticCache.IndicatorScore.FirstOrDefault(x => x.DistrictSk == districtSk && x.SnapshotPeriod == selectYear);
            foreach(var indicator in indicatorList)
            {
                var singleIndexRank = GetSingleIndexRank(indicator, selectYear, StaticCache.Districts.Count(x => x.CityName == x.DistrictName));
                CityRank cityRank = new CityRank()
                {
                    IndexName = indicator,
                    RankPlace = singleIndexRank.SingleIndexList.FirstOrDefault(x => x.DistrictSk == districtSk).RankPlace
                };
                cityRankList.Add(cityRank);
            }
            //foreach (var indicator in indicatorList)
            //{
            //    CityRank cityRank = new CityRank()
            //    {
            //        IndexName = indicator,
            //        IndexValue = ((double)indicatorScore.GetValueByName(indicator)).ToString("0.00")
            //    };
            //    cityRankList.Add(cityRank);
            //}
            cityRankList = cityRankList.OrderByDescending(x => float.Parse(x.IndexValue)).Take(dataCount).ToList();
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

        /// <summary>
        /// 获取数据库咨讯信息
        /// </summary>
        public List<NewsModel> GetNewsList()
        {
            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.ShortDatePattern = "yyyy-MM-dd";
            List<NewsModel> model = StaticCache.DdsNews.Select(x => new NewsModel()
            {
                NewsTitle = x.Title,
                NewsContent = x.Content,
                NewsReleaseDate = Convert.ToDateTime(x.ReleaseTime, dtFormat).ToString("yyyy-MM-dd"),
                NewTags = x.Tags.Split(';').ToList()
            }).ToList();

            return model;
        }

    }
}