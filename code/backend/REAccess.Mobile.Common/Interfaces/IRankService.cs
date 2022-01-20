#region Using
using REAccess.Mobile.Common.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace REAccess.Mobile.Common.Interfaces
{
    public interface IRankService : IDisposable
    {
        /// <summary>
        /// 单指标排名，根据用户选择的指标获取该指标的真实数据进行排名，取排名前N的指标
        /// </summary>
        public SingleIndexModel GetSingleIndexRank(string selectIndex, string selectYear, int dataCount);

        /// <summary>
        /// 城市排名,根据用户选择的城市，获取该城市的每一个指标在所有城市中的排名，并取出名次最高的五个指标
        /// </summary>
        public CityRankModel GetCityRank(string selectCity, string selectYear, int dataCount);

        /// <summary>
        /// 获取数据库咨讯信息
        /// </summary>
        public List<NewsModel> GetNewsList();
    }
}
