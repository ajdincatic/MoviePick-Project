using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class MovieAndTvshowGenre
    {
        public int Id { get; set; }
        public int MovieAndTvshowId { get; set; }
        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual MovieAndTvshow MovieAndTvshow { get; set; }
    }
}
