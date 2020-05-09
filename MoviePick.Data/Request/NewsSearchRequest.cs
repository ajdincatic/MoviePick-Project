using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class NewsSearchRequest
    {
        public int AuthorId { get; set; }
        public DateTime DateTimeOfNews { get; set; }
        public string Title { get; set; }
    }
}
