using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class Quote
    {
        public int Id { get; set; }
        public int MovieAndTvshowId { get; set; }
        public string QuoteText { get; set; }

        public virtual MovieAndTvshow MovieAndTvshow { get; set; }
    }
}
