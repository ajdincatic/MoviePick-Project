using System;
using System.Collections.Generic;

namespace MoviePick.Database
{
    public partial class User
    {
        public User()
        {
            Comment = new HashSet<Comment>();
            News = new HashSet<News>();
            Rating = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public int UserTypeId { get; set; }

        public virtual UserType UserType { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
    }
}
