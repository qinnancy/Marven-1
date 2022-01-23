using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class AppRoleConfig
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleType { get; set; }
        public string CanRead { get; set; }
        public string CanWrite { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }

        public virtual AppRole Role { get; set; }
    }
}
