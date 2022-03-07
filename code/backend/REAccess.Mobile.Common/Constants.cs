#region
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace REAccess.Mobile.Common
{
    public class Constants
    {
        public static class ResponseStatusCode
        {
            public const int Exception = -2;
            public const int Error = -1;
            public const int Success = 0;
            public const int Warning = 1;
            public const int Information = 2;
        }

        public static class ResponseStatusMessage
        {
            public const string Success = "Success";
            public const string Failed = "Failed";
        }
        public static class DbYesOrNo
        {
            public const string Yes = "Y";
            public const string No = "N";
        }
        public static class NoData
        {
            public const string NotPublished = "-999,999";
        }
        public static class DistrictData
        {
            public const string China = "中华人民共和国";
            public const int ChinaSkId = 640;
            public const string ProjectPhase1 = "Phase 1";
            public const string DeloitteRank = "德勤指标";
        }
        public static class IndustryRankUnit
        {
            public const string ByCounts = "个";
            public const string ByAmount = "亿元";
            public const string DetailAmount = "亿元";
            public const string NullVaule = "未披露";
            public const string ByLandSize = "亩";
            public const string Growth = "%";
            public const string Year = "年";
        }
        public static class LandRankUnit
        {
            public const string TransactionAmountUnit = "亿元";
            public const string TransactionAmountUnitOfTable = "万元";
            public const string TransactionAreaUnit = "万㎡";
            public const string TransactionSumUnit = "笔";
            public const string TransactionCountUnit = "个";
        }
        public static class Industrycategory
        {
            public const string ActiveRegion = "活跃区域";
            public const string HotIndustry = "热点产业";
            public const string EnterpriseInvestment = "企业投资";
            public const string IndustryLand = "产业用地";
        }
        public static class SearchPageMatch
        {
            public const string City = "城市";
            public const string Indicator = "指标";
            public const string Industry = "产业";
            public const string PolicyCategory = "政策类";
            public const string PlanningClass = "规划类";
        }
        public static class MobileData
        {
            public static List<string> AllIndexList = new List<string>() {"人均GDP","GDP增速","实际利用外资","社会消费品零售总额","一般公共预算自给率","新增常住人口","全市居民人均可支配收入","全市居民人均消费支出","上市企业数量","高新技术企业数量",
                    "专精特新“小巨人”企业数量","上市企业研发投入占比","货物运输总量","港口货物吞吐量","相对劳动力成本","房价收入比","每千人医疗机构床位数量","每十万人基础教育学校数量","每十万人地铁站点数量","每十万人星巴克数量"};
            public static List<string> AllCityList = new List<string>() { "北京市","天津市","上海市","重庆市","沈阳市","大连市","长春市","哈尔滨市","南京市","苏州市","无锡市","杭州市","宁波市","合肥市","福州市","厦门市","济南市","青岛市","郑州市",
                    "武汉市","长沙市","广州市","深圳市","佛山市","成都市","西安市"};
        }
        public static class DataFile
        {
            public const string FileName = "mobile_data_20220307.xlsx";
        }
    }
}
