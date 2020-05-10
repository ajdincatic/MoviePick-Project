using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class GenreMovieTvShowSearchRequest
    {
        public int MovieAndTvshowId { get; set; }
        public int GenreId { get; set; }
    }
}
