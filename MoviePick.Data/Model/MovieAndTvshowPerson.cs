using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Model
{
    public class MovieAndTvshowPerson
    {
        //public int MovieAndTvshowId { get; set; }
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int RoleId { get; set; }
        public string NameInMovie { get; set; }
    }
}
