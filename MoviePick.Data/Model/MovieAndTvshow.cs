using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Model
{
    public class MovieAndTvshow
    {
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
        public ProductionCompany ProductionCompany { get; set; }
        public ICollection<MovieTvShowGenre> MovieAndTvshowGenre { get; set; }
        public ICollection<TvshowSeason> TvshowSeason { get; set; }
    }
}
