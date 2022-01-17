using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DsaListedCompanies
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int ProvinceSk { get; set; }
        public int? CitySk { get; set; }
        public int? DistrictSk { get; set; }
        public string Location { get; set; }
        public int PrimaryIndustryKey { get; set; }
        public int SecondaryIndustryKey { get; set; }
        public string PrimaryProducts { get; set; }
        public decimal? MarketValue { get; set; }
        public decimal? MarketValueYoy { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? RevenueYoy { get; set; }
        public decimal? NetProfit { get; set; }
        public decimal? NetProfitYoy { get; set; }
        public decimal? Tax { get; set; }
        public decimal? TaxYoy { get; set; }
        public decimal? RndCost { get; set; }
        public decimal? RndCostYoy { get; set; }
        public DateTime? LaunchDate { get; set; }
        public int Id { get; set; }
    }
}
