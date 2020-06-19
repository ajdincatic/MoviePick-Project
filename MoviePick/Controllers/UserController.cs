using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Controllers;
using eProdaja.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviePick.Data.Request;
using MoviePick.Interfaces;

namespace MoviePick.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Data.Model.User> GetAll([FromQuery] UserSearchRequest search)
        {
            return _service.Get(search);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("{Id}")]
        public Data.Model.User GetById(int Id)
        {
            return _service.GetById(Id);
        }

        [HttpPost]
        public Data.Model.User Post(UserUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize]
        [HttpPut("{Id}")]
        public Data.Model.User Update(int Id, [FromBody]UserUpsertRequest request)
        {
            return _service.Update(Id, request);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{Id}")]
        public Data.Model.User Delete(int Id)
        {
            return _service.Delete(Id);
        }
    }
}