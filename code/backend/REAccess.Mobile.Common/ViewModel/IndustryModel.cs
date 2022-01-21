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
    public class PolicyModel
    {
        public List<IndustrialPolicy> IndustrialPolicis { get; set; }
        public int IndustrialPolicyCount { get; set; }
    }
    public class IndustrialPolicy
    {
        public int PolicyId { get; set; }
        public string FileName { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
    }
    public class PolicyDetail
    {
        public string FileName { get; set; }
        public string FileLevel { get; set; }
        public string IssuingAgency { get; set; }
        public string SupportAreas { get; set; }
        public string ReleaseDate { get; set; }
        public string ClosingDate { get; set; }
        public string DetailsLink { get; set; }
        public string FileCategory { get; set; }
    }
}
