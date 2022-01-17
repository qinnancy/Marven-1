using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppDictGroup
    {
        public AppDictGroup()
        {
            AppDictItem = new HashSet<AppDictItem>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AppDictItem> AppDictItem { get; set; }
    }
}
