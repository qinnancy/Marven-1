﻿#region Using
using REAccess.Mobile.Common.Interfaces;
using REAccess.Mobile.Common.Utils;
using REAccess.Mobile.Common.ViewModel;
using REAccess.Mobile.Database.LogModels;
using REAccess.Mobile.Database.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using static REAccess.Mobile.Common.Constants;
#endregion

namespace REAccess.Mobile.Common.Services
{
    public class UtilService : BaseService, IUtilService
    {

        ///<summary>
        ///清理所有正在使用的资源
        ///</summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 获取当前所有三级指标
        /// </summary>
        public List<string> GetAllIndex()
        {
            List<string> indexList = StaticCache.Indicators.Where(x => x.Class == 3 && x.Valid == DbYesOrNo.Yes).Select(x => x.Name).Distinct().ToList();

            return indexList;
        }
        /// <summary>
        /// 单项指标-指标下拉列表
        /// </summary>
        public List<string> GetMobileAllIndex()
        {
            List<string> indexList = MobileData.AllIndexList;

            return indexList;
        }

        /// <summary>
        /// 获取城市列表
        /// </summary>
        public List<string> GetCityList()
        {
            List<string> cityList = StaticCache.Districts.OrderBy(x => x.RankingOfProvinces).Select(x => x.CityName).Distinct().ToList();

            return cityList;
        }
        
        /// <summary>
        /// 城市排名-城市下拉列表
        /// </summary>
        public List<string> GetMobileCityList()
        {
            List<string> cityList = MobileData.AllCityList;

            return cityList;
        }

        /// <summary>
        /// 获取政策类别列表
        /// </summary>
        public List<PolicyListModel> GetPolicyList()
        {
            List<PolicyListModel> policyList = _db.DsaIndustryFieldTag.Where(x => x.Category == 1 && x.IsValid == DbYesOrNo.Yes).OrderBy(x => x.OrderNum).Select(x => new PolicyListModel() 
            {
                PolicyId = x.Id,
                PolicyName = x.Name
            }).ToList();

            return policyList;
        }
        /// <summary>
        /// 记录系统日志
        /// </summary>
        public string SysLog(string pageName, string previousPage)
        {
            string result = ResponseStatusMessage.Success;
            if (string.IsNullOrEmpty(previousPage) && string.IsNullOrEmpty(pageName))
            {
                result = ResponseStatusMessage.Failed;
            }
            

            return result;
        }

        /// <summary>
        /// 根据指标名称，获取数据库有数据的年份
        /// </summary>
        public List<string> GetYearListByIndexName(string indicator)
        {
            List<string> yearList = new List<string>();
            var indicatorRankList = StaticCache.IndicatorScore.ToList();
            string indexName = IndicatorMappingExtension.GetIndexName(indicator);
            if (!string.IsNullOrEmpty(indexName))
            {
                yearList = indicatorRankList.Where(x => x.GetType().GetProperty(indexName).GetValue(x, null) != null)
                                                      .GroupBy(x => x.SnapshotPeriod)
                                                      .Select(x => x.FirstOrDefault())
                                                      .OrderByDescending(x => x.SnapshotPeriod)
                                                      .Select(x => x.SnapshotPeriod)
                                                      .ToList();
            }
            if (!yearList.Any())
            {
                yearList = indicatorRankList.GroupBy(x => x.SnapshotPeriod).Select(x => x.First()).OrderByDescending(x => x.SnapshotPeriod).Select(x => x.SnapshotPeriod).ToList();
            }

            return yearList;

        }
        public List<CityRank> GetCityRankData(string cityName)
        {
            List<CityRank> cityRankList = new List<CityRank>();
            var filePath = Path.Combine("DataFiles", "mobile_data 20220301.xlsx");
            Stream stream = new FileInfo(filePath).OpenRead();
            var dataTable = FileHelper.ReadDataFromFile(stream, true, "城市排名data");
            if(dataTable != null)
            {
                for(var i = 0; i < dataTable.Rows.Count; i++)
                {
                    CityRank cityRank = new CityRank()
                    {
                        CityName = dataTable.Rows[i][0].ToString() + "市",
                        RankPlace = int.Parse(dataTable.Rows[i][1].ToString().Split("#").Last()),
                        IndexName = dataTable.Rows[i][2].ToString(),
                        IndexValue = dataTable.Rows[i][3].ToString(),
                        Unit = dataTable.Rows[i][4].ToString(),
                        Year = dataTable.Rows[i][5].ToString()
                    };
                    cityRankList.Add(cityRank);
                }
            }
            cityRankList = cityRankList.Where(x => x.CityName == cityName).ToList();

            return cityRankList;
        }

    }
}
