using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoviePick.Data.Request
{
    public class NewsUpsertRequest
    {
        [Required]
        public DateTime DateTimeOfNews { get; set; }
        [Required(AllowEmptyStrings = false)]
        public byte[] CoverPhoto { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Title { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public List<int> MoveTvShowIds { get; set; } = new List<int>();
    }
}
