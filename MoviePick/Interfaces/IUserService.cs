using MoviePick.Data.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Interfaces
{
    interface IUserService
    {
        Data.Model.User Authenticiraj(UserLoginRequest request);
    }
}
