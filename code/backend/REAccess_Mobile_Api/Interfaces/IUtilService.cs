using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REAccess_Mobile_Api.Interfaces
{
    public interface IUtilService : IDisposable
    {
        //获取所有三级指标
        public List<string> GetAllIndex();
        //获取城市列表
        public List<string> GetCityList();
    }
}
