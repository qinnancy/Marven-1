#region
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace REAccess.Mobile.Common.ViewModel
{
    public class NewsModel
    {
        public int Id { get; set; }
        public string NewsTitle { get; set; }
        public string NewsContent { get; set; }
        public byte[] NewsImage { get; set; }
        public List<string> NewTags { get; set; }
        public string NewsReleaseDate { get; set; }
    }
}
