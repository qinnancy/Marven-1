using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DdsNewsTags
    {
        public int Id { get; set; }
        public int NewsId { get; set; }
        public string NewsTag { get; set; }
        public string TagsRoute { get; set; }
        public string Isvalid { get; set; }

        public virtual DdsNewsBack News { get; set; }
    }
}
