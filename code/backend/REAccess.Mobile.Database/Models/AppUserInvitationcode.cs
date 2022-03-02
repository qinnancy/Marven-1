using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class AppUserInvitationcode
    {
        public int Id { get; set; }
        public string InvitationCode { get; set; }
        public string IsUsed { get; set; }
        public string IsValid { get; set; }
    }
}
