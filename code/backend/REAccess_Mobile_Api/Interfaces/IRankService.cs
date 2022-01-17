using REAccess_Mobile_Commen.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REAccess_Mobile_Api.Interfaces
{
    public interface IRankService : IDisposable
    {
        //单指标排名
        public SingleIndexModel GetSingleIndexRank(string selectIndex, string selectYear);
        //城市排名
        public CityRankModel GetCityRank(string selectCity, string selectYear);
    }
}
