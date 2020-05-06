using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class UserType
    {
        public UserType()
        {
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
