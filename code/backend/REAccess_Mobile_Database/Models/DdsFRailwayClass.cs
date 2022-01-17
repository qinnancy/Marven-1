using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DdsFRailwayClass
    {
        public int DistrictSk { get; set; }
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string StationClass { get; set; }
        public int? StationCount { get; set; }
        public int Id { get; set; }
    }
}
