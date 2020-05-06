using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class News
    {
        public News()
        {
            MovieAndTvshowNews = new HashSet<MovieAndTvshowNews>();
        }

        public int Id { get; set; }
        public int AuthorId { get; set; }
        public DateTime DateTimeOfNews { get; set; }
        public byte[] CoverPhoto { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }

        public virtual User Author { get; set; }
        public virtual ICollection<MovieAndTvshowNews> MovieAndTvshowNews { get; set; }
    }
}
