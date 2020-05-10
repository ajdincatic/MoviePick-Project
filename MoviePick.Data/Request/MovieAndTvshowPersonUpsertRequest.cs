using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class MovieAndTvshowPersonUpsertRequest
    {
        public int PersonId { get; set; }
        public int RoleId { get; set; }
        public int MovieAndTvshowId { get; set; }
        public string NameInMovie { get; set; }
    }
}
