using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DdsFInnovationData
    {
        public int DistrictSk { get; set; }
        public string RegionalLevel { get; set; }
        public string DataPeriod { get; set; }
        public decimal? ListedCompaniesResearchBudget { get; set; }
        public int? NationalEnterpriseTechCenters { get; set; }
        public int? NationalResearchLabs { get; set; }
        public int? UndergraduateAndAcademy { get; set; }
        public int? College211985 { get; set; }
        public int? PostdoctoralResearchStation { get; set; }
        public int? TechBasedSme { get; set; }
        public int? HighTechEnterprises { get; set; }
        public int? InventionPatentsPer10kPpl { get; set; }
        public int? GraduatesAtSchoolCount { get; set; }
        public int? UndergraduatesAtSchoolCount { get; set; }
        public int Id { get; set; }
    }
}
