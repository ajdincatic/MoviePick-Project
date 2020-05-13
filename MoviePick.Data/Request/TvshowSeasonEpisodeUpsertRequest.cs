using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class TvshowSeasonEpisodeUpsertRequest
    {
        public string EpisodeName { get; set; }
        public DateTime AirDate { get; set; }
        public int TvshowSeasonId { get; set; }
        public int EpisodeNumber { get; set; }
    }
}
