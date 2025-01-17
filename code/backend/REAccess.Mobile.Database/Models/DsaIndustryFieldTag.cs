﻿using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaIndustryFieldTag
    {
        public DsaIndustryFieldTag()
        {
            DsaPolicyIndustryFieldTagRelation = new HashSet<DsaPolicyIndustryFieldTagRelation>();
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public int? Category { get; set; }
        public int? OrderNum { get; set; }
        public string IsValid { get; set; }

        public virtual ICollection<DsaPolicyIndustryFieldTagRelation> DsaPolicyIndustryFieldTagRelation { get; set; }
    }
}
