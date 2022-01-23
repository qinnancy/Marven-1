using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class AppRoleFunction
    {
        public long Id { get; set; }
        public int? RoleId { get; set; }
        public long? FunctionId { get; set; }

        public virtual AppFunction Function { get; set; }
        public virtual AppRole Role { get; set; }
    }
}
