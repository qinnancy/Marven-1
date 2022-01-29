using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.LogModels
{
    public partial class ReaMobileSysLog
    {
        public long Id { get; set; }
        public DateTime Entered { get; set; }
        public string Url { get; set; }
        public string RawUrl { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string SessionId { get; set; }
        public string Description { get; set; }
        public string IpDetail { get; set; }
        public string PageName { get; set; }
        public string SectionName { get; set; }
        public string CityIndexPolicyIndustryParamName { get; set; }
        public string BrowseType { get; set; }
        public string PreviousPage { get; set; }
    }
}
