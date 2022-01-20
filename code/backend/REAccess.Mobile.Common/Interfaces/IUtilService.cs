#region Using
using REAccess.Mobile.Common.ViewModel;
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
        /// 获取城市列表
        /// </summary>
        public List<string> GetCityList();
    }
}
