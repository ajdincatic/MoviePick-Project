using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class TvshowSeasonUpsertRequest
    {
        public int MovieAndTvshowId { get; set; }
        public bool? Finished { get; set; }
    }
}
