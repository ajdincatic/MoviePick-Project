using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class CommentUpsertRequest
    {
        public int AppUserId { get; set; }
        public int MovieAndTvshowId { get; set; }
        public DateTime DateTimeOfComment { get; set; }
        public string Content { get; set; }
    }
}
