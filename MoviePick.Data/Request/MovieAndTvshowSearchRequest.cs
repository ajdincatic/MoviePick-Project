using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class MovieAndTvshowSearchRequest
    {
        public string Title { get; set; }
        public string ReleaseYear { get; set; }
        public string KeyWord { get; set; }
        public int GenreId { get; set; }
        public string Genre { get; set; }
        public string Actor { get; set; }
        public int ProductionCompanyId { get; set; }
        public bool? isTvShow { get; set; }
    }
}
