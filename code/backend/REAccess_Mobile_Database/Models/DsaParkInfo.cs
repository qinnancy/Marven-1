using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DsaParkInfo
    {
        public DsaParkInfo()
        {
            DsaParkMainIndustry = new HashSet<DsaParkMainIndustry>();
            DsaParkWebsites = new HashSet<DsaParkWebsites>();
        }

        public long Id { get; set; }
        public long? DistrictId { get; set; }
        public string ZoneClass { get; set; }
        public string ZoneType { get; set; }
        public string ZoneName { get; set; }
        public long? ZoneArea { get; set; }
        public string Prov { get; set; }
        public string City { get; set; }

        public virtual ICollection<DsaParkMainIndustry> DsaParkMainIndustry { get; set; }
        public virtual ICollection<DsaParkWebsites> DsaParkWebsites { get; set; }
    }
}
