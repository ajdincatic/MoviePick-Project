using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class Genre
    {
        public Genre()
        {
            MovieAndTvshowGenre = new HashSet<MovieAndTvshowGenre>();
        }

        public int Id { get; set; }
        public string GenreName { get; set; }

        public virtual ICollection<MovieAndTvshowGenre> MovieAndTvshowGenre { get; set; }
    }
}
