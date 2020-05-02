using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class TvshowSeason
    {
        public TvshowSeason()
        {
            TvshowSeasonEpisode = new HashSet<TvshowSeasonEpisode>();
        }

        public int Id { get; set; }
        public int MovieAndTvshowId { get; set; }
        public bool? Finished { get; set; }

        public virtual MovieAndTvshow MovieAndTvshow { get; set; }
        public virtual ICollection<TvshowSeasonEpisode> TvshowSeasonEpisode { get; set; }
    }
}
