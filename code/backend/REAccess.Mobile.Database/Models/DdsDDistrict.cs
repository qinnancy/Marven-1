using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DdsDDistrict
    {
        public DdsDDistrict()
        {
            CityGroup = new HashSet<CityGroup>();
            DevelopmentDistrict = new HashSet<DevelopmentDistrict>();
        }

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
        public int? GdpRank { get; set; }
        public string CityLevel { get; set; }
        public int? RankingOfProvinces { get; set; }
        public int? RankingOfCities { get; set; }

        public virtual ICollection<CityGroup> CityGroup { get; set; }
        public virtual ICollection<DevelopmentDistrict> DevelopmentDistrict { get; set; }
    }
}
