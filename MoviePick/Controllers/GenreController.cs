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
    public class GenreController : BaseController<Data.Model.Genre, object>
    {
        public GenreController(IService<Data.Model.Genre, object> service) : base(service)
        {

        }
    }
}