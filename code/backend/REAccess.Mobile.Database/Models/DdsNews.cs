using System;
using System.Collections.Generic;

namespace REAccess.Mobile.Database.Models
{
    public partial class DdsNews
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public DateTime ReleaseTime { get; set; }
        public int IsValid { get; set; }
        public int IsTop { get; set; }
        public int IsHot { get; set; }
        public string Tags { get; set; }
    }
}
