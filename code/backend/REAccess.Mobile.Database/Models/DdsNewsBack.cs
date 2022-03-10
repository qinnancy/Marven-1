using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DdsNewsBack
    {
        public DdsNewsBack()
        {
            DdsNewsTags = new HashSet<DdsNewsTags>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public DateTime ReleaseTime { get; set; }
        public string IsValid { get; set; }
        public int? CategoryOrder { get; set; }
        public int? NewsOrder { get; set; }

        public virtual ICollection<DdsNewsTags> DdsNewsTags { get; set; }
    }
}
