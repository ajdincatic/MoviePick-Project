using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class UserUpsertRequest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public int UserTypeId { get; set; }
    }
}
