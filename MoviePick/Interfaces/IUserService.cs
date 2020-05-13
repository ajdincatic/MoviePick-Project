using MoviePick.Data.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Interfaces
{
    public interface IUserService
    {
        Data.Model.User Authenticate(UserLoginRequest request);
        List<Data.Model.User> Get(UserSearchRequest search);
        Data.Model.User GetById(int Id);
        Data.Model.User Insert(UserUpsertRequest request);
        Data.Model.User Update(int Id, UserUpsertRequest request);
        Data.Model.User Delete(int Id);
    }
}
