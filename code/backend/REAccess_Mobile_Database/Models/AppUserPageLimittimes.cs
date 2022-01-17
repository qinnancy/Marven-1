using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppUserPageLimittimes
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public long FunctionId { get; set; }
        public int Count { get; set; }
        public string Isvalid { get; set; }

        public virtual AppFunction Function { get; set; }
        public virtual AppUser User { get; set; }
    }
}
