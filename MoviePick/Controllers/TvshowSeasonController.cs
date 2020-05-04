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
    public class TvshowSeasonController 
        : BaseCRUDController<Data.Model.TvshowSeason, TvshowSeasonSearchRequest, TvshowSeasonUpsertRequest, TvshowSeasonUpsertRequest>
    {
        public TvshowSeasonController
            (ICRUDService<Data.Model.TvshowSeason, TvshowSeasonSearchRequest, TvshowSeasonUpsertRequest, TvshowSeasonUpsertRequest> service) : base(service)
        {

        }
    }
}