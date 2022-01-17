using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppUser
    {
        public AppUser()
        {
            AppAccessLog = new HashSet<AppAccessLog>();
            AppFeedback = new HashSet<AppFeedback>();
            AppRankingList = new HashSet<AppRankingList>();
            AppSurveyAnswer = new HashSet<AppSurveyAnswer>();
            AppUserPageLimittimes = new HashSet<AppUserPageLimittimes>();
            AppUserPreference = new HashSet<AppUserPreference>();
            AppUserRole = new HashSet<AppUserRole>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserPassword { get; set; }
        public DateTime? RegTime { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public string UserApproved { get; set; }
        public string Isvalid { get; set; }
        public string IsDeleted { get; set; }
        public string UserProvince { get; set; }
        public string UserCity { get; set; }
        public string UserDistrict { get; set; }
        public string UserZone { get; set; }
        public string UserIndustry { get; set; }
        public string UserPosition { get; set; }
        public string CompanyName { get; set; }
        public DateTime? SigningStartTime { get; set; }
        public DateTime? SigningEndTime { get; set; }
        public int? UseCounts { get; set; }
        public string UserType { get; set; }
        public string PrimeMoverIndustry { get; set; }
        public string EmailReminder { get; set; }
        public string JupiterCode { get; set; }

        public virtual ICollection<AppAccessLog> AppAccessLog { get; set; }
        public virtual ICollection<AppFeedback> AppFeedback { get; set; }
        public virtual ICollection<AppRankingList> AppRankingList { get; set; }
        public virtual ICollection<AppSurveyAnswer> AppSurveyAnswer { get; set; }
        public virtual ICollection<AppUserPageLimittimes> AppUserPageLimittimes { get; set; }
        public virtual ICollection<AppUserPreference> AppUserPreference { get; set; }
        public virtual ICollection<AppUserRole> AppUserRole { get; set; }
    }
}
