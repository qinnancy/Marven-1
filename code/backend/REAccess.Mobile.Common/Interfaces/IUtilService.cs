#region Using
using REAccess.Mobile.Common.ViewModel;
using REAccess.Mobile.Database.LogModels;
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace REAccess.Mobile.Common.Interfaces
{
    public interface IUtilService : IDisposable
    {
        /// <summary>
        /// 获取当前所有三级指标
        /// </summary>
        public List<string> GetAllIndex();
        /// <summary>
        /// 单项指标-指标下拉列表
        /// </summary>
        public List<string> GetMobileAllIndex();
        /// <summary>
        /// 获取城市列表
        /// </summary>
        public List<string> GetCityList();
        /// <summary>
        /// 城市排名-城市下拉列表
        /// </summary>
        public List<string> GetMobileCityList();
        /// <summary>
        /// 获取政策类别列表
        /// </summary>
        public List<PolicyListModel> GetPolicyList();
        /// <summary>
        /// 记录系统日志
        /// </summary>
        public string SysLog(string pageName, string previousPage);
        /// <summary>
        /// 根据指标名称，获取数据库有数据的年份
        /// </summary>
        public List<string> GetYearListByIndexName(string indexName);
        /// <summary>
        /// 读取excel数据包城市排名数据
        /// </summary>
        public List<CityRank> GetCityRankData(string cityName);
        /// <summary>
        /// 读取excel数据包政策数据
        /// </summary>
        public List<IndustrialPolicy> GetPolicyData();
        /// <summary>
        /// 读取excel数据包政策数据
        /// </summary>
        public PolicyDetail GetPolicyData(string policyName);
        /// <summary>
        /// 读取excel数据包产业用地数据
        /// </summary>
        public List<CityRank> GetLandHotIndustryData();
        /// <summary>
        /// 读取excel数据包单项排名数据
        /// </summary>
        public SingleIndexModel GetSingleRankData(string selectIndex);
        /// <summary>
        /// 读取excel数据包资讯数据
        /// </summary>
        public List<NewsModel> GetNewsData();
        /// <summary>
        /// 读取excel数据包产业投资-区域数据
        /// </summary>
        public List<RankModel> GetActiveAreaData();
        /// <summary>
        /// 产业投资-区域-下沉页数据
        /// </summary>
        public List<ProjectDetail> GetCityInvestProjectData(string cityName);
        /// <summary>
        /// 产业投资-行业-下沉页数据
        /// </summary>
        public List<ProjectDetail> GetIndustryInvestProjectData(string industryName);
        /// <summary>
        /// 读取excel数据包产业投资-热点产业数据
        /// </summary>
        public List<CityRank> GetHotIndustryData();
        /// <summary>
        /// 读取excel数据包产业拿地-活跃区域数据
        /// </summary>
        /// <returns></returns>
        public List<RankModel> GetIndusrtyActiveRegionData();
        /// <summary>
        /// 产业用地-活跃区域-下沉页数据
        /// </summary>
        public List<ProjectDetail> GetCityIndustryProjectData(string cityName);
        /// <summary>
        /// 产业用地-热点产业-下沉页数据
        /// </summary>
        public List<ProjectDetail> GetIndustryProjectData(string industryName);
    }
}
