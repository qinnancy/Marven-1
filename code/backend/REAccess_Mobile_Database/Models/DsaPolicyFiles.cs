using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class DsaPolicyFiles
    {
        public DsaPolicyFiles()
        {
            DsaPolicyIndustryFieldTagRelation = new HashSet<DsaPolicyIndustryFieldTagRelation>();
        }

        public string Name { get; set; }
        public string Fields { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Level { get; set; }
        public string Organization { get; set; }
        public string Link { get; set; }
        public DateTime? ReleaseTime { get; set; }
        public DateTime? ExpireTime { get; set; }
        public string Category { get; set; }
        public int Id { get; set; }
        public string FileCode { get; set; }
        public string FileName { get; set; }

        public virtual ICollection<DsaPolicyIndustryFieldTagRelation> DsaPolicyIndustryFieldTagRelation { get; set; }
    }
}
