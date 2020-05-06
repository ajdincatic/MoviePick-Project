using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Controllers;
using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviePick.Data.Request;

namespace MoviePick.Controllers
{
    public class UserController :
        BaseCRUDController<Data.Model.User, UserSearchRequest, UserUpsertRequest, UserUpsertRequest>
    {
        public UserController
            (ICRUDService<Data.Model.User, UserSearchRequest, UserUpsertRequest, UserUpsertRequest> service) : base(service)
        {

        }
    }
}