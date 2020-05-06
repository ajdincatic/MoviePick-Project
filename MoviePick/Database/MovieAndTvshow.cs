using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class MovieAndTvshow
    {
        public MovieAndTvshow()
        {
            Comment = new HashSet<Comment>();
            MovieAndTvshowGenre = new HashSet<MovieAndTvshowGenre>();
            MovieAndTvshowNews = new HashSet<MovieAndTvshowNews>();
            MovieAndTvshowPerson = new HashSet<MovieAndTvshowPerson>();
            Quote = new HashSet<Quote>();
            Rating = new HashSet<Rating>();
            TvshowSeason = new HashSet<TvshowSeason>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string RunningTime { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double? Budget { get; set; }
        public byte[] Poster { get; set; }
        public int NumberOfRatings { get; set; }
        public bool? Finished { get; set; }
        public int ProductionCompanyId { get; set; }

        public virtual ProductionCompany ProductionCompany { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<MovieAndTvshowGenre> MovieAndTvshowGenre { get; set; }
        public virtual ICollection<MovieAndTvshowNews> MovieAndTvshowNews { get; set; }
        public virtual ICollection<MovieAndTvshowPerson> MovieAndTvshowPerson { get; set; }
        public virtual ICollection<Quote> Quote { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
        public virtual ICollection<TvshowSeason> TvshowSeason { get; set; }
    }
}
