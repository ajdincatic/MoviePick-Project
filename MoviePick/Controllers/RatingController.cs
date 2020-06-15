using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviePick.Data.Request;
using MoviePick.Interfaces;

namespace MoviePick.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _service;

        public RatingController(IRatingService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Data.Model.Rating> Get([FromQuery]RatingSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Data.Model.Rating InsertRatingByUser(RatingUpsertRequest request)
        {
            return _service.InsertRatingByUser(request);
        }
    }
}