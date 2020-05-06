using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class NewsUpsertRequest
    {
        public DateTime DateTimeOfNews { get; set; }
        public byte[] CoverPhoto { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
    }
}
