using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DsaPolicyIndustryFieldTagRelation
    {
        public int Id { get; set; }
        public int PolicyId { get; set; }
        public int IndustryFieldTagId { get; set; }

        public virtual DsaIndustryFieldTag IndustryFieldTag { get; set; }
        public virtual DsaPolicyFiles Policy { get; set; }
    }
}
