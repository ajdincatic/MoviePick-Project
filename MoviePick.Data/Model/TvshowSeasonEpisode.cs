using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Model
{
    public class TvshowSeasonEpisode
    {
        public int Id { get; set; }
        public string EpisodeName { get; set; }
        public DateTime AirDate { get; set; }
        public int TvshowSeasonId { get; set; }
        public int? EpisodeNumber { get; set; }
        public int? TvshowId { get; set; }
        public TvshowSeason TvshowSeason { get; set; }
    }
}
