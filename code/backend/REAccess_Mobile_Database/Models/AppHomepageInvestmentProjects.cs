using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppHomepageInvestmentProjects
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string SharesName { get; set; }
        public string InvestmentArea { get; set; }
        public string InvestmentScale { get; set; }
        public string InvestmentScaleUnit { get; set; }
        public string OutputValue { get; set; }
        public string OutputValueUnit { get; set; }
        public string Isvalid { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
