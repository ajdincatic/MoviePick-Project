using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int UserTypeId { get; set; }

        public UserType UserType { get; set; }
    }
}
