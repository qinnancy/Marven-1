using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class LargeCompanyDevelopTrend
    {
        public long? IndustryKey { get; set; }
        public long? IndicatorKey { get; set; }
        public long? SnapshotPeriod { get; set; }
        public decimal? IndexYoy { get; set; }
        public decimal? IndexValue { get; set; }
        public long? Id { get; set; }
        public long? ProvCode { get; set; }
        public long? CityCode { get; set; }
        public long? DistrictCode { get; set; }
        public decimal? IndicatorValueOfLastYear { get; set; }
    }
}
