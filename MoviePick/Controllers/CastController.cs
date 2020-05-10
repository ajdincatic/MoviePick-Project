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
    public class CastController :
        BaseCRUDController<Data.Model.MovieAndTvshowPerson, MovieAndTvshowPersonSearchRequest, MovieAndTvshowPersonUpsertRequest, MovieAndTvshowPersonUpsertRequest>
    {
        public CastController
            (ICRUDService<Data.Model.MovieAndTvshowPerson, MovieAndTvshowPersonSearchRequest, MovieAndTvshowPersonUpsertRequest, MovieAndTvshowPersonUpsertRequest> service) : base(service)
        {

        }
    }
}
