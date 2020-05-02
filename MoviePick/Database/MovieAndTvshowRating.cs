using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class MovieAndTvshowRating
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public int MovieAndTvshowId { get; set; }
        public int RatingValue { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual MovieAndTvshow MovieAndTvshow { get; set; }
    }
}
