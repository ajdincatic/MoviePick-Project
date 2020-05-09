using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Model
{
    public class Rating
    {
        public int AppUserId { get; set; }
        public int MovieAndTvshowId { get; set; }
        public int RatingValue { get; set; }
    }
}
