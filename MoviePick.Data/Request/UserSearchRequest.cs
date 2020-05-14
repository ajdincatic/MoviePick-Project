using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePick.Data.Request
{
    public class UserSearchRequest
    {
        public string Username { get; set; }
        public int UserTypeId { get; set; }
    }
}
