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
    public class MovieAndTvShowController
        : BaseCRUDController<Data.Model.MovieAndTvshow, MovieAndTvshowSearchRequest, MovieAndTvshowUpsertRequest, MovieAndTvshowUpsertRequest>
    {
        public MovieAndTvShowController
            (ICRUDService<Data.Model.MovieAndTvshow, MovieAndTvshowSearchRequest, MovieAndTvshowUpsertRequest, MovieAndTvshowUpsertRequest> service) : base(service)
        {

        }
    }
}