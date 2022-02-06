#region Using
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
        /// 获取城市列表
        /// </summary>
        public List<string> GetCityList()
        {
            List<string> cityList = StaticCache.Districts.OrderBy(x => x.RankingOfProvinces).Select(x => x.CityName).Distinct().ToList();

            return cityList;
        }
        /// <summary>
        /// 获取政策类别列表
        /// </summary>
        public List<PolicyListModel> GetPolicyList()
        {
            List<PolicyListModel> policyList = _db.DsaIndustryFieldTag.Where(x => x.Category == 1).OrderBy(x => x.OrderNum).Select(x => new PolicyListModel() 
            {
                PolicyId = x.Id,
                PolicyName = x.Name
            }).ToList();

            return policyList;
        }
    }
}
