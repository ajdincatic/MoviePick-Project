using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public int MovieAndTvshowId { get; set; }
        public DateTime DateTimeOfComment { get; set; }
        public string Content { get; set; }

        public virtual User AppUser { get; set; }
        public virtual MovieAndTvshow MovieAndTvshow { get; set; }
    }
}
