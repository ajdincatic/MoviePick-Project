using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class MovieAndTvshowNews
    {
        public int Id { get; set; }
        public int? MovieAndTvshowId { get; set; }
        public int? NewsId { get; set; }

        public virtual MovieAndTvshow MovieAndTvshow { get; set; }
        public virtual News News { get; set; }
    }
}
