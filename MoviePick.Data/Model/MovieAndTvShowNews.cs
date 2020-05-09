using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Model
{
    public class MovieAndTvShowNews
    {
        public int? NewsId { get; set; }
        public int? MovieAndTvshowId { get; set; }

        public MovieAndTvshow MovieAndTvshow { get; set; }
    }
}
