using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoviePick.Data.Request
{
    public class QuoteUpsertRequest
    {
        [Required]
        public int MovieAndTvshowId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string QuoteText { get; set; }
    }
}
