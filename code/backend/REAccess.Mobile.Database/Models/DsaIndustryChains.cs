using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaIndustryChains
    {
        public string Industry { get; set; }
        public string IndustryChainPosition { get; set; }
        public string IndustryChainName { get; set; }
        public string IndustryChainDesc { get; set; }
        public string MainEnterprise1 { get; set; }
        public string MainEnterprise2 { get; set; }
        public string MainEnterprise3 { get; set; }
        public double? MainEnterpriseCount { get; set; }
        public double? ListedEnterpriseCount { get; set; }
        public double? InvestedEnterpriseCount { get; set; }
    }
}
