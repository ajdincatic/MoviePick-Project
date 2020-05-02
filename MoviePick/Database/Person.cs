using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class Person
    {
        public Person()
        {
            MovieAndTvshowPerson = new HashSet<MovieAndTvshowPerson>();
        }

        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public string Biography { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }

        public virtual ICollection<MovieAndTvshowPerson> MovieAndTvshowPerson { get; set; }
    }
}
