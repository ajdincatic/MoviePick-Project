using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Model
{
    public class TvshowSeason
    {
        public int Id { get; set; }
        public bool? Finished { get; set; }
        public int MovieAndTvshowId { get; set; }
        public string SeasonName { get; set; }

        public MovieAndTvshow MovieAndTvshow { get; set; }
    }
}
