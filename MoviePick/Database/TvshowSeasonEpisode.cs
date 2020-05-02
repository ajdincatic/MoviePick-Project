using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class TvshowSeasonEpisode
    {
        public int Id { get; set; }
        public int TvshowSeasonId { get; set; }
        public string EpisodeName { get; set; }
        public DateTime AirDate { get; set; }

        public virtual TvshowSeason TvshowSeason { get; set; }
    }
}
