using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DdsFMacroData
    {
        public int DistrictSk { get; set; }
        public string RegionalLevel { get; set; }
        public string DataPeriod { get; set; }
        public decimal? Gdp { get; set; }
        public decimal? LandSize { get; set; }
        public decimal? PermenantResidents { get; set; }
        public decimal? HouesholdPopulation { get; set; }
        public decimal? RegisteredCompanies { get; set; }
        public decimal? ImportAndExport { get; set; }
        public decimal? ConsumerGoodsRetailSales { get; set; }
        public decimal? FixedAssetsInvestment { get; set; }
        public int? DevelopmentAreaCount { get; set; }
        public int Id { get; set; }
    }
}
