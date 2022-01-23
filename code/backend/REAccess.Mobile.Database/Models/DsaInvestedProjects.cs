using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaInvestedProjects
    {
        public int Id { get; set; }
        public long? DistrictSk { get; set; }
        public DateTime? InvestDate { get; set; }
        public string InvestCompany { get; set; }
        public string ProjectName { get; set; }
        public decimal? InvestAmount10k { get; set; }
        public string IndustryPrimaryClassKey { get; set; }
        public string IndustrySecondaryClassKey { get; set; }
        public decimal? LandSize { get; set; }
        public decimal? ProjectAnnualProduction10k { get; set; }
        public decimal? ProjectAnnualTax10k { get; set; }
        public string ProjectContent { get; set; }
        public string ProjectCapacity { get; set; }
        public string Notes { get; set; }
        public long? CitySk { get; set; }
        public string ProjectLocation { get; set; }
        public int ProvinceSk { get; set; }
    }
}
