using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class PersonUpsertRequest
    {
        public string Biography { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public byte[] Photo { get; set; }

    }
}
