using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class SorDistrictMaster
    {
        public int DistrictSk { get; set; }
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string ProvAdCode { get; set; }
        public string CityAdCode { get; set; }
        public string DistrictAdCode { get; set; }
        public string CityCode { get; set; }
        public string ProvCenterCoords { get; set; }
        public string CityCenterCoords { get; set; }
        public string DistrictCenterCoords { get; set; }
        public string ProjectPhase { get; set; }
    }
}
