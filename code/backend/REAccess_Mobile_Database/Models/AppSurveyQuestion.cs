using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppSurveyQuestion
    {
        public AppSurveyQuestion()
        {
            AppSurveyQuestion1 = new HashSet<AppSurvey>();
            AppSurveyQuestion2 = new HashSet<AppSurvey>();
            AppSurveyQuestion3 = new HashSet<AppSurvey>();
            AppSurveyQuestion4 = new HashSet<AppSurvey>();
            AppSurveyQuestion5 = new HashSet<AppSurvey>();
            AppSurveyUserAnswer = new HashSet<AppSurveyUserAnswer>();
        }

        public int Id { get; set; }
        public string UserType { get; set; }
        public string Question { get; set; }
        public string Type { get; set; }
        public int? OptionalCounts { get; set; }
        public string Mandatory { get; set; }
        public string IsValid { get; set; }
        public string Options { get; set; }
        public int QuestionOrder { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<AppSurvey> AppSurveyQuestion1 { get; set; }
        public virtual ICollection<AppSurvey> AppSurveyQuestion2 { get; set; }
        public virtual ICollection<AppSurvey> AppSurveyQuestion3 { get; set; }
        public virtual ICollection<AppSurvey> AppSurveyQuestion4 { get; set; }
        public virtual ICollection<AppSurvey> AppSurveyQuestion5 { get; set; }
        public virtual ICollection<AppSurveyUserAnswer> AppSurveyUserAnswer { get; set; }
    }
}
