using REAccess_Mobile_Common.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REAccess_Mobile_Api.Interfaces
{
    public interface IIndustryService : IDisposable
    {
        //产业投资--企业投资--活跃区域
        public List<RankModel> GetActiveAreaRank();
        //产业投资--企业投资--热点产业
        public List<CityRank> GetHotIndustryRank();
        //产业投资-产业用地-活跃区域
        public List<RankModel> GetIndusrtyActiveRegion();
        //产业投资-产业用地-看热点产业
        public List<CityRank> GetLandHotIndustryRank();
        //获取项目信息
        public IndustryModel GetIndustryProject(string primaryCategory, string secondaryCategory, string currentId);
    }
}
