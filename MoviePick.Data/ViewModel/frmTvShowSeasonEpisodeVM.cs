using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.ViewModel
{
    public class frmTvShowSeasonEpisodeVM
    {
        public int Id { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeName { get; set; }
        public DateTime AirDate { get; set; }
    }
}
