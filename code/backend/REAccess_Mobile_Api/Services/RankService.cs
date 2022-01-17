using REAccess_Mobile_Api.Interfaces;
using REAccess_Mobile_Api.Utils;
using REAccess_Mobile_Commen.ViewModel;
using REAccess_Mobile_Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static REAccess_Mobile_Commen.Constants;

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
            List<SingleIndex> singleIndexList = new List<SingleIndex>();
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
                    SingleIndex singleIndex = new SingleIndex()
                    {
                        CityName = district.CityName,
                        ProvinceName = district.ProvName,
                        RankValue = ((decimal)indicator.GetOriginalValueByName(selectIndex)).ToString("N0")
                    };
                    singleIndexList.Add(singleIndex);
                }
            }
            singleIndexList = singleIndexList.OrderByDescending(x => float.Parse(x.RankValue)).Take(5).ToList();
            foreach(var data in singleIndexList)
            {
                data.RankPlace = singleIndexList.IndexOf(data) + 1;
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
                    IndexScore = ((double)indicatorScore.GetValueByName(indicator)).ToString("0.00")
                };
                cityRankList.Add(cityRank);
            }
            cityRankList = cityRankList.OrderByDescending(x => float.Parse(x.IndexScore)).Take(5).ToList();
            foreach (var data in cityRankList)
            {
                data.RankPlace = cityRankList.IndexOf(data) + 1;
            }
            model.CityRankList = cityRankList;

            return model;
        }
    }
}
