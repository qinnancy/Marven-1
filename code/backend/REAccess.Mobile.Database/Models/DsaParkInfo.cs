using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaParkInfo
    {
        public long? DistrictId { get; set; }
        public string ZoneClass { get; set; }
        public string ZoneType { get; set; }
        public string ZoneName { get; set; }
        public long? ZoneArea { get; set; }
        public string Prov { get; set; }
        public string City { get; set; }
        public int? ZoneClassOrder { get; set; }
        public int? ZoneTypeOrder { get; set; }
        public long Id { get; set; }
        public string HasGovWebsite { get; set; }
    }
}
