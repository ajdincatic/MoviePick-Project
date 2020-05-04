using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class PersonSearchRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
    }
}
