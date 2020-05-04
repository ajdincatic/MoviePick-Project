using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Controllers;
using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoviePick.Controllers
{
    public class RoleController : BaseController<Data.Model.Role, object>
    {
        public RoleController(IService<Data.Model.Role, object> service) : base(service)
        {

        }
    }
}