using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class UserLoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
