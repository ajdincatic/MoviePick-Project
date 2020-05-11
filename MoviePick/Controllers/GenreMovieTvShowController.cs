using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Controllers;
using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviePick.Data.Request;
using MoviePick.Interfaces;

namespace MoviePick.Controllers
{
    public class GenreMovieTvShowController : BaseController<Data.Model.MovieTvShowGenre, GenreMovieTvShowSearchRequest>
    {
        public GenreMovieTvShowController(IService<Data.Model.MovieTvShowGenre, GenreMovieTvShowSearchRequest> service) : base(service)
        {

        }
    }
}