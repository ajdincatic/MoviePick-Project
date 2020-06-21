using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Model
{
    public class Quote
    {
        public int Id { get; set; }
        public string QuoteText { get; set; }
        public int MovieAndTvshowId { get; set; }
        public MovieAndTvshow MovieAndTvshow { get; set; }
    }
}
