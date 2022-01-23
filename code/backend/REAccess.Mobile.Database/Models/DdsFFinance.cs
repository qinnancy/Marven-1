using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DdsFFinance
    {
        public int DistrictSk { get; set; }
        public string DataPeriod { get; set; }
        public string TimeGranularity { get; set; }
        public string RegionalLevel { get; set; }
        public int? BankCount { get; set; }
        public int? InsuranceCompanyCount { get; set; }
        public int? SecurityCompanyCount { get; set; }
        public double? FicisalBudget { get; set; }
        public double? LocalGovernmentDebt { get; set; }
        public int? PevcCount { get; set; }
        public double? BankLoanBalance { get; set; }
        public int Id { get; set; }
    }
}
