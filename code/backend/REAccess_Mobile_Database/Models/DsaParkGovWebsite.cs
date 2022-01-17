using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DsaParkGovWebsite
    {
        public long Id { get; set; }
        public long? GovId { get; set; }
        public string GovName { get; set; }
        public string Website { get; set; }

        public virtual DsaParkGov Gov { get; set; }
    }
}
