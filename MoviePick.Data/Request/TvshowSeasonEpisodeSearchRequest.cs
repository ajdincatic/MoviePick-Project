using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class TvshowSeasonEpisodeSearchRequest
    {
        public int TvshowSeasonId { get; set; }
        public int TvshowId { get; set; }
    }
}
