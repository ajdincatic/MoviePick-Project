using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoviePick.Data.Request
{
    public class UserUpsertRequest
    {
        // validated in mobile and desktop apps
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress()]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public int UserTypeId { get; set; }
    }
}
