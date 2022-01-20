#region
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace REAccess.Mobile.Common.ViewModel
{
    public class IndustryModel
    {
        public string PrimaryName { get; set; }
        public string InvestProjectCount { get; set; }
        public string InvestProjectAmount { get; set; }
        public List<ProjectDetail> ProjectList { get; set; }
    }
    public class ProjectDetail
    {
        public string InvestmentCompany { get; set; }
        public string ProjectLocation { get; set; }
        public string ProjectIndustry { get; set; }
        public string ProjectCapacity { get; set; }
        public string AreaCovered { get; set; }
        public string TransactionAmount { get; set; }
        public string AnnualOutput { get; set; }
        public string AnnualTax { get; set; }
        public string TransferDate { get; set; }
    }
}
