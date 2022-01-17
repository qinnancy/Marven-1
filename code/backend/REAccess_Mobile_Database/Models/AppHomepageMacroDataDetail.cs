using System;
using System.Collections.Generic;

namespace REAccess_Mobile_Database.Models
{
    public partial class AppHomepageMacroDataDetail
    {
        public int Id { get; set; }
        public int MacroDataId { get; set; }
        public string ParticularYear { get; set; }
        public string ParticularYearData { get; set; }

        public virtual AppHomepageMacroData MacroData { get; set; }
    }
}
