using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class AppFunction
    {
        public AppFunction()
        {
            AppAccessLog = new HashSet<AppAccessLog>();
            AppRoleFunction = new HashSet<AppRoleFunction>();
            AppUserPageLimittimes = new HashSet<AppUserPageLimittimes>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Page { get; set; }
        public string Route { get; set; }

        public virtual ICollection<AppAccessLog> AppAccessLog { get; set; }
        public virtual ICollection<AppRoleFunction> AppRoleFunction { get; set; }
        public virtual ICollection<AppUserPageLimittimes> AppUserPageLimittimes { get; set; }
    }
}
