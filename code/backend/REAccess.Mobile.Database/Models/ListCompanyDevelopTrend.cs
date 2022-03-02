using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class ListCompanyDevelopTrend
    {
        public long? SnapshotPeriod { get; set; }
        public string StockName { get; set; }
        public string Code { get; set; }
        public string MainProduct { get; set; }
        public long? IndustryKey { get; set; }
        public long? IndicatorKey { get; set; }
        public decimal? IndicatorValue { get; set; }
        public decimal? IndicatorYoY { get; set; }
        public long? ProvCode { get; set; }
        public long? CityCode { get; set; }
        public long? DistrictCode { get; set; }
        public decimal? IndicatorValueOfLastYear { get; set; }
        public long Id { get; set; }
    }
}
