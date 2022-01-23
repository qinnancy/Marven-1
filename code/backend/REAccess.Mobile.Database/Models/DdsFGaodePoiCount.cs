using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DdsFGaodePoiCount
    {
        public int DistrictSk { get; set; }
        public string IndicatorType { get; set; }
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public int PoiCount { get; set; }
        public int Id { get; set; }
    }
}
