using System;
using System.Collections.Generic;
using System.Text;

namespace REAccess_Mobile_Common.ViewModel
{
    public class NewsModel
    {
        public string NewsTitle { get; set; }
        public string NewsContent { get; set; }
        public List<string> NewTags { get; set; }
        public string NewsReleaseDate { get; set; }
    }
}
