using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviePick.Data.Request;
using MoviePick.Interfaces;

namespace MoviePick.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _service;

        public CommentController(ICommentService service)
        {
            _service = service;
        }

        [Authorize(Roles = "MobileAppUser")]
        [HttpGet]
        public List<Data.Model.Comment> Get([FromQuery] CommentSearchRequest request)
        {
            return _service.Get(request);
        }

        [Authorize]
        [HttpPost]
        public Data.Model.Comment Insert(CommentUpsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}