using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class UserType
    {
        public UserType()
        {
            AppUser = new HashSet<AppUser>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<AppUser> AppUser { get; set; }
    }
}
