using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoviePick.Data.Request
{
    public class MovieAndTvshowUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Title { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Language { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string RunningTime { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        public double? Budget { get; set; }
        [Required]
        public byte[] Poster { get; set; }
        public int NumberOfRatings { get; set; }
        public bool? Finished { get; set; }
        [Required]
        public int ProductionCompanyId { get; set; }
        public int NrOfRatings { get; set; }
        public List<int> GenreIds { get; set; } = new List<int>();
    }
}
