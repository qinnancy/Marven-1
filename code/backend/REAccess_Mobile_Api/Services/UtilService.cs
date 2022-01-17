using REAccess_Mobile_Api.Interfaces;
using REAccess_Mobile_Api.Utils;
using REAccess_Mobile_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static REAccess_Mobile_Commen.Constants;

namespace REAccess_Mobile_Api.Services
{
    public class UtilService : ServiceBase,IUtilService
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        //获取当前所有三级指标
        public List<string> GetAllIndex()
        {
            List<string> indexList = StaticCache.Indicators.Where(x => x.Class == 3 && x.Valid == DbYesOrNo.Yes).Select(x => x.Name).Distinct().ToList();

            return indexList;
        }

        //获取城市列表
        public List<string> GetCityList()
        {
            List<string> cityList = StaticCache.Districts.OrderBy(x => x.RankingOfProvinces).Select(x => x.CityName).Distinct().ToList();

            return cityList;
        }
    }
}
