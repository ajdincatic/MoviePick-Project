using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoviePick.Data.Request
{
    public class TvshowSeasonEpisodeUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string EpisodeName { get; set; }
        [Required]
        public DateTime AirDate { get; set; }
        [Required]
        public int TvshowSeasonId { get; set; }
        [Required]
        public int TvshowId { get; set; }
        [Required]
        public int EpisodeNumber { get; set; }
    }
}
