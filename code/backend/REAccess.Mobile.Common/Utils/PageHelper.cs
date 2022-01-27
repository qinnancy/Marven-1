#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace REAccess.Mobile.Common.Utils
{
    public static class PageHelper
    {
        /// <summary>
        /// 分页泛型工具类
        /// </summary>
        /// <typeparam name="T">被分页的数据类型</typeparam>
        /// <param name="pageIndex">当前页数</param>
        /// <param name="pageSize">每页显示个数</param>
        /// <param name="pageData">被分页的数据</param>
        /// <returns></returns>
        public static List<T> PageUtil<T>(int pageIndex, int pageSize, List<T> pageData)
        {
            var currentData = pageData.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            return currentData;
        }

    }
}
