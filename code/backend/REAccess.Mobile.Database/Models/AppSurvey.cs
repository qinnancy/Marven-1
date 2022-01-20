using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class AppSurvey
    {
        public AppSurvey()
        {
            AppSurveyAnswer = new HashSet<AppSurveyAnswer>();
        }

        public int Id { get; set; }
        public int Question1Id { get; set; }
        public int? Question2Id { get; set; }
        public int? Question3Id { get; set; }
        public int? Question4Id { get; set; }
        public int? Question5Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public string IsActive { get; set; }

        public virtual AppSurveyQuestion Question1 { get; set; }
        public virtual AppSurveyQuestion Question2 { get; set; }
        public virtual AppSurveyQuestion Question3 { get; set; }
        public virtual AppSurveyQuestion Question4 { get; set; }
        public virtual AppSurveyQuestion Question5 { get; set; }
        public virtual ICollection<AppSurveyAnswer> AppSurveyAnswer { get; set; }
    }
}
