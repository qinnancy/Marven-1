using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaParkWebsitesBak
    {
        public long Id { get; set; }
        public long? ParkId { get; set; }
        public string GovName { get; set; }
        public string Website { get; set; }
    }
}
