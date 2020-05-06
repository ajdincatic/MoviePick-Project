using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviePick.Interfaces;

namespace MoviePick.Controllers
{
    [Route("api")]
    [ApiController]
    public class Genre_MovieTvShowController : ControllerBase
    {
        private readonly IGenreMovieTvShowService _service;

        public Genre_MovieTvShowController(IGenreMovieTvShowService service)
        {
            _service = service;
        }

        [HttpGet("MovieTvShow/{MTVSId}/Genre")]
        public List<Data.Model.Genre> GetGenresByMTVS(int MTVSId)
        {
            return _service.GetGenresByMTVS(MTVSId);
        }

        [HttpGet("Genre/{GenreId}/MovieTvShow")]
        public List<Data.Model.MovieAndTvshow> GetMTVSByGenre(int GenreId)
        {
            return _service.GetMTVSByGenre(GenreId);
        }
    }
}