using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Model
{
    public class MovieTvShowGenre
    {
        public int MovieAndTvshowId { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public MovieAndTvshow MovieAndTvshow { get; set; }
    }
}
