using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppRole
    {
        public AppRole()
        {
            AppRoleConfig = new HashSet<AppRoleConfig>();
            AppRoleFunction = new HashSet<AppRoleFunction>();
            AppUserRole = new HashSet<AppUserRole>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }

        public virtual ICollection<AppRoleConfig> AppRoleConfig { get; set; }
        public virtual ICollection<AppRoleFunction> AppRoleFunction { get; set; }
        public virtual ICollection<AppUserRole> AppUserRole { get; set; }
    }
}
