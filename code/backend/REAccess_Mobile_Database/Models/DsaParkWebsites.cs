using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DsaParkWebsites
    {
        public long Id { get; set; }
        public long? ParkId { get; set; }
        public string GovName { get; set; }
        public string Website { get; set; }

        public virtual DsaParkInfo Park { get; set; }
    }
}
