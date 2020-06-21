using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoviePick.Data.Request
{
    public class PersonUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Gender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public string PlaceOfBirth { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Biography { get; set; }
        [Required]
        public byte[] Photo { get; set; }

    }
}
