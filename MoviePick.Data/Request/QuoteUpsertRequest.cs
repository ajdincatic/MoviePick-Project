using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class QuoteUpsertRequest
    {
        public int MovieAndTvshowId { get; set; }
        public string QuoteText { get; set; }
    }
}
