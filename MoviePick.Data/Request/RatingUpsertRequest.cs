using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoviePick.Data.Request
{
    public class RatingUpsertRequest
    {
        [Required]
        public int AppUserId { get; set; }
        [Required]
        public int MovieAndTvshowId { get; set; }
        [Required]
        public int RatingValue { get; set; }
    }
}
