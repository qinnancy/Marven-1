using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DevelopmentDistrict
    {
        public int Id { get; set; }
        public int DistrictSk { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Coords { get; set; }

        public virtual DdsDDistrict DistrictSkNavigation { get; set; }
    }
}
