﻿using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaParkMainIndustry
    {
        public long Id { get; set; }
        public long? ParkId { get; set; }
        public string MainIndustry { get; set; }

        public virtual DsaParkInfo Park { get; set; }
    }
}