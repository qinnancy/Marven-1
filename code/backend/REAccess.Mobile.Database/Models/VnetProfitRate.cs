using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class VnetProfitRate
    {
        public long Id { get; set; }
        public long? SnapshotPeriod { get; set; }
        public long? IndustryKey { get; set; }
        public long? IndicatorKey { get; set; }
        public decimal? IncomeIndicatorValue { get; set; }
        public decimal? NetProfitIndicatorValue { get; set; }
        public decimal? LastIncomeIndicatorValue { get; set; }
        public decimal? LastNetProfitIndicatorValue { get; set; }
        public long? ProvCode { get; set; }
        public long? CityCode { get; set; }
        public long? DistrictCode { get; set; }
        public string IndustryName { get; set; }
        public byte? IndustryClass { get; set; }
        public int? IndustryOrder { get; set; }
        public string Unit { get; set; }
    }
}
