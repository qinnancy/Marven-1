using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppHomepageMacroData
    {
        public AppHomepageMacroData()
        {
            AppHomepageMacroDataDetail = new HashSet<AppHomepageMacroDataDetail>();
        }

        public int Id { get; set; }
        public string KpiName { get; set; }
        public string KpiUnit { get; set; }
        public string Isvalid { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<AppHomepageMacroDataDetail> AppHomepageMacroDataDetail { get; set; }
    }
}
