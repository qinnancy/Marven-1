#region Using
using REAccess.Mobile.Common.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace REAccess.Mobile.Common.Interfaces
{
    public interface IIndustryService : IDisposable
    {
        /// <summary>
        /// 产业投资--企业投资--活跃区域
        /// 筛选规则：全部产业/投资项目数量/全国/最新年份的排名
        /// </summary>
        public List<RankModel> GetActiveAreaRank(int dataCount);

        /// <summary>
        ///产业投资--企业投资--热点产业
        ///筛选规则：全国/投资项目数量/国民经济行业门类/最新年份的排名
        /// </summary>
        public List<CityRank> GetHotIndustryRank(int dataCount);

        /// <summary>
        ///产业投资-产业用地-活跃区域
        ///筛选条件：全部产业/土地成交笔数/全国/最新年份
        /// </summary>
        public List<RankModel> GetIndusrtyActiveRegion(int dataCount);

        /// <summary>
        ///产业投资-产业用地-看热点产业
        ///筛选规则：全国/土地成交笔数/国民经济行业门类/最新年份的排名
        /// </summary>
        public List<CityRank> GetLandHotIndustryRank(int dataCount);

        /// <summary>
        /// 获取项目信息
        /// </summary>
        public IndustryModel GetIndustryProject(string primaryCategory, string secondaryCategory, string currentId,int dataCount);
        /// <summary>
        /// 获取政策数据
        /// </summary>
        public PolicyModel GetPolicyData(int industryId, string policyCategory, int dataCount);
        /// <summary>
        /// 获取政策文件详细信息
        /// </summary>
        public PolicyDetail GetPolicyDetail(int policyId);
    }
}
