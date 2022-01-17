using System;
using System.Collections.Generic;
using System.Text;

namespace REAccess_Mobile_Commen
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

        public static class ResponseMessage
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
    }
}
