using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class SorGdcMacroScaleData
    {
        public string DataCategory { get; set; }
        public string DataName { get; set; }
        public string RegionalLevel { get; set; }
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string TimeGranularity { get; set; }
        public string DataPeriod { get; set; }
        public decimal? DataValue { get; set; }
        public string DataUnit { get; set; }
        public DateTime? DataCollectedAt { get; set; }
        public string DataSource { get; set; }
        public string DataNotes { get; set; }
    }
}
