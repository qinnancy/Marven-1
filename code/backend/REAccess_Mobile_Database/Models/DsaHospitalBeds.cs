using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DsaHospitalBeds
    {
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string HospitalCode { get; set; }
        public string HospitalName { get; set; }
        public string HospitalClass { get; set; }
        public string NoOfBeds { get; set; }
        public string DataStatus { get; set; }
        public string ReferenceUrl { get; set; }
    }
}
