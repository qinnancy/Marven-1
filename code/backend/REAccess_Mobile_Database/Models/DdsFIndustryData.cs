using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DdsFIndustryData
    {
        public int DistrictSk { get; set; }
        public string RegionalLevel { get; set; }
        public string Industry { get; set; }
        public string Market { get; set; }
        public string TimeGranularity { get; set; }
        public string DataPeriod { get; set; }
        public decimal? ListedCompaniesCount { get; set; }
        public decimal? ListedCompaniesMarketValue { get; set; }
        public decimal? ListedCompaniesIncome { get; set; }
        public decimal? ListedCompaniesEbit { get; set; }
        public int? LargeEnterprisesCount { get; set; }
        public decimal? LargeEnterprisesAssets { get; set; }
        public decimal? LargeEnterprisesProduction { get; set; }
        public long? LargeEnterprisesStaffCount { get; set; }
        public int? UnicornsCount { get; set; }
        public decimal? UnicornsEstimatedValue { get; set; }
        public decimal? InvestedCompaniesCount { get; set; }
        public decimal? InvestedCompaniesInvestedAmount { get; set; }
        public decimal? GovernmentFundsSize { get; set; }
        public int? NationalUnicornsCount { get; set; }
        public decimal? NationalUnicornsEstimatedValue { get; set; }
        public int? NationalInvestedCompaniesCount { get; set; }
        public decimal? NationalInvestedCompaniesInvestedAmount { get; set; }
        public decimal? NationalLargeEnterprisesAssets { get; set; }
        public int Id { get; set; }
    }
}
