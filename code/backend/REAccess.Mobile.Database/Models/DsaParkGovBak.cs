using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaParkGovBak
    {
        public long Id { get; set; }
        public long? DistrictCode { get; set; }
        public string CityFullName { get; set; }
        public string DistrictFullName { get; set; }
        public string CityLevel { get; set; }
        public string Prov { get; set; }
        public string City { get; set; }
        public string District { get; set; }
    }
}
