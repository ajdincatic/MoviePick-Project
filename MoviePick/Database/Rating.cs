using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class Rating
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public int MovieAndTvshowId { get; set; }
        public int RatingValue { get; set; }

        public virtual User AppUser { get; set; }
        public virtual MovieAndTvshow MovieAndTvshow { get; set; }
    }
}
