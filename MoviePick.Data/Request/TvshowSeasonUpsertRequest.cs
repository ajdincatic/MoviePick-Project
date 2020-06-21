using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoviePick.Data.Request
{
    public class TvshowSeasonUpsertRequest
    {
        [Required]
        public int MovieAndTvshowId { get; set; }
        public bool? Finished { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string SeasonName { get; set; }
    }
}
