using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoviePick.Data.Request
{
    public class MovieAndTvshowPersonUpsertRequest
    {
        [Required]
        public int PersonId { get; set; }
        [Required]
        public int RoleId { get; set; }
        [Required]
        public int MovieAndTvshowId { get; set; }
        public string NameInMovie { get; set; }
    }
}
