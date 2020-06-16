using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class CommentSearchRequest
    {
        public int MovieAndTvshowId { get; set; }
        public int AppUserId { get; set; }
    }
}
