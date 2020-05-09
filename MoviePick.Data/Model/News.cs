using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Model
{
    public class News
    {
        public int Id { get; set; }
        public DateTime DateTimeOfNews { get; set; }
        public byte[] CoverPhoto { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public ICollection<MovieAndTvShowNews> MovieAndTvshowNews { get; set; }
    }
}
