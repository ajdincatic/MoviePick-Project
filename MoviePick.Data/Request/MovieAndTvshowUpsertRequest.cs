using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class MovieAndTvshowUpsertRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string RunningTime { get; set; }
        public string ReleaseDate { get; set; }
        public double? Budget { get; set; }
        public byte[] Poster { get; set; }
        public int NumberOfRatings { get; set; }
        public bool? Finished { get; set; }
        public int ProductionCompanyId { get; set; }
        public List<int> GenreIds { get; set; } = new List<int>();
        public List<Tuple<int, int, string>> Roles { get; set; } = new List<Tuple<int, int, string>>();
    }
}
