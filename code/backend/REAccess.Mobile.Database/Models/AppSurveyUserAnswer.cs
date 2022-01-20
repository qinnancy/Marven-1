using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class AppSurveyUserAnswer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public string UserAnswer { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual AppSurveyQuestion Question { get; set; }
    }
}
