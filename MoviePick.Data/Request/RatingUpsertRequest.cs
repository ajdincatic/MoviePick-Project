using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class RatingUpsertRequest
    {
        public int AppUserId { get; set; }
        public int MovieAndTvshowId { get; set; }
        public int RatingValue { get; set; }
    }
}
