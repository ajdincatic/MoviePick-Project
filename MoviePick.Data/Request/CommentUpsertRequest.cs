using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoviePick.Data.Request
{
    public class CommentUpsertRequest
    {
        [Required]
        public int AppUserId { get; set; }
        [Required]
        public int MovieAndTvshowId { get; set; }
        [Required]
        public DateTime DateTimeOfComment { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Content { get; set; }
    }
}
