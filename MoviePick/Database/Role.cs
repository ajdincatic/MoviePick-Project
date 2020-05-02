using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class Role
    {
        public Role()
        {
            MovieAndTvshowPerson = new HashSet<MovieAndTvshowPerson>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<MovieAndTvshowPerson> MovieAndTvshowPerson { get; set; }
    }
}
