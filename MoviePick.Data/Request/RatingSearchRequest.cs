using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class RatingSearchRequest
    {
        public int AppUserId { get; set; }
        public int MovieAndTvshowId { get; set; }
    }
}
