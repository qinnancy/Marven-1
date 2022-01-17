using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppSurveyAnswer
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public int UserId { get; set; }
        public string Question1Answer { get; set; }
        public string Question2Answer { get; set; }
        public string Question3Answer { get; set; }
        public string Question4Answer { get; set; }
        public string Question5Answer { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual AppSurvey Survey { get; set; }
        public virtual AppUser User { get; set; }
    }
}
