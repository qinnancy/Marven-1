using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaListedCompanyInvestment
    {
        public DateTime? InvestDate { get; set; }
        public string InvestCompany { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public double? InvestAmount10k { get; set; }
        public string CompanyCode { get; set; }
        public string Market { get; set; }
        public string WindCategoryLevel1 { get; set; }
        public string WindCategoryLevel2 { get; set; }
        public string WindCategoryLevel3 { get; set; }
        public string WindCategoryLevel4 { get; set; }
        public string WindCategoryLevelLeaf { get; set; }
        public string NationalIndustriesClass { get; set; }
        public string NationalIndustriesSecondaryClass { get; set; }
        public string NationalIndustriesClassLevel { get; set; }
        public string ProjectProv { get; set; }
        public string ProjectCity { get; set; }
        public string ProjectDistrict { get; set; }
        public string ProjectProduction { get; set; }
        public string ProjectCapacity { get; set; }
        public string ProjectAnnualTax { get; set; }
        public string ProjectContent { get; set; }
        public string Note { get; set; }
        public string Source1 { get; set; }
        public string Source2 { get; set; }
        public string IndustrialPark { get; set; }
        public string LandSize { get; set; }
        public double? InvestAmount100m { get; set; }
        public int Id { get; set; }
    }
}
