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
        }
        public static class Industrycategory
        {
            public const string ActiveRegion = "活跃区域";
            public const string HotIndustry = "热点产业";
            public const string EnterpriseInvestment = "企业投资";
            public const string IndustryLand = "产业用地";
        }
    }
}
