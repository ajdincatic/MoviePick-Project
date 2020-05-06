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
    [Route("api")]
    [ApiController]
    public class MovieTvShow_PersonController : ControllerBase
    {
        private readonly IMovieTvShowPersonService _service;

        public MovieTvShow_PersonController(IMovieTvShowPersonService service)
        {
            _service = service;
        }

        [HttpGet("MovieTvShow/{MTVSId}/Person")]
        public List<Data.Model.Person> GetPersonsByMTVS(int MTVSId, int RoleId)
        {
            return _service.GetPersonsByMTVS(MTVSId, RoleId);
        }

        [HttpGet("Person/{PersonId}/MovieTvShow")]
        public List<Data.Model.MovieAndTvshow> GetMTVSsbyPerson(int PersonId)
        {
            return _service.GetMTVSsbyPerson(PersonId);
        }

        [HttpPost("MovieTvShow/{MTVSId}/Person")]
        public Data.Model.MovieAndTvshowPerson AddPersonToMTVS(int MTVSId, MovieAndTvshowPersonUpsertRequest request)
        {
            return _service.AddPersonToMTVS(MTVSId, request);
        }
    }
}