using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class MovieAndTvshowSearchRequest
    {
        public string Title { get; set; }
        public int ProductionCompanyId { get; set; }
        public bool isTvShow { get; set; }
    }
}
