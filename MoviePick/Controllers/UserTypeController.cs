using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Controllers;
using eProdaja.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoviePick.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserTypeController : BaseController<Data.Model.UserType, object>
    {
        public UserTypeController(IService<Data.Model.UserType, object> service) : base(service)
        {

        }
    }
}