using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DsaParkGov
    {
        public DsaParkGov()
        {
            DsaParkGovWebsite = new HashSet<DsaParkGovWebsite>();
        }

        public long Id { get; set; }
        public int? DistrictCode { get; set; }
        public string CityFullName { get; set; }
        public string DistrictFullName { get; set; }
        public string CityLevel { get; set; }
        public string Prov { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public virtual ICollection<DsaParkGovWebsite> DsaParkGovWebsite { get; set; }
    }
}
