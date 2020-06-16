using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Model
{
    public class Comment
    {
        public int AppUserId { get; set; }
        public int MovieAndTvshowId { get; set; }
        public DateTime DateTimeOfComment { get; set; }
        public string Content { get; set; }
        public virtual User AppUser { get; set; }
    }
}
