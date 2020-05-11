using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.ViewModel
{
    public class frmMovieTvShowSearchVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string RunningTime { get; set; }
        public bool? Finished { get; set; }
        public string ProductionCompany { get; set; }
        public string Genres { get; set; }
    }
}
