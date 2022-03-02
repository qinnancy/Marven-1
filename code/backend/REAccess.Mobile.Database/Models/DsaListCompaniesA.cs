using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaListCompaniesA
    {
        public long? Id { get; set; }
        public string StockName { get; set; }
        public string Code { get; set; }
        public string PrimaryProduct { get; set; }
        public string ProvCode { get; set; }
        public string CityCode { get; set; }
        public string DistrictCode { get; set; }
        public string Location { get; set; }
        public string PrimaryIndustryKey { get; set; }
        public string SecondaryIndustryKey { get; set; }
        public float? MarketValue { get; set; }
        public string MarketValueYoY { get; set; }
        public string Revenue { get; set; }
        public string RevenueYoY { get; set; }
        public string NetProfit { get; set; }
        public string NetProfitYoY { get; set; }
        public string Tax { get; set; }
        public string TaxYoY { get; set; }
        public string RndCost { get; set; }
        public string RndCostYoY { get; set; }
        public DateTime? LaunchDate { get; set; }
        public string Website { get; set; }
        public long? PublishYear { get; set; }
    }
}
