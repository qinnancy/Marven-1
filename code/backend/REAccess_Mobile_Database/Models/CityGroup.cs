using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class CityGroup
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public int CitySk { get; set; }

        public virtual DdsDDistrict CitySkNavigation { get; set; }
    }
}
