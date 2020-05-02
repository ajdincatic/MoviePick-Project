using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class MovieAndTvshowPerson
    {
        public int Id { get; set; }
        public int MovieAndTvshowId { get; set; }
        public int PersonId { get; set; }
        public int RoleId { get; set; }
        public string NameInMovie { get; set; }

        public virtual MovieAndTvshow MovieAndTvshow { get; set; }
        public virtual Person Person { get; set; }
        public virtual Role Role { get; set; }
    }
}
