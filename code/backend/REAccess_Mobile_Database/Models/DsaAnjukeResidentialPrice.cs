using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DsaAnjukeResidentialPrice
    {
        public string ProvName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public int? Fangjia { get; set; }
    }
}
