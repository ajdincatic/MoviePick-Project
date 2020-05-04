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
    public class TvshowSeasonEpisodeController
        : BaseCRUDController<Data.Model.TvshowSeasonEpisode, TvshowSeasonEpisodeSearchRequest, TvshowSeasonEpisodeUpsertRequest, TvshowSeasonEpisodeUpsertRequest>
    {
        public TvshowSeasonEpisodeController
            (ICRUDService<Data.Model.TvshowSeasonEpisode, TvshowSeasonEpisodeSearchRequest, TvshowSeasonEpisodeUpsertRequest, TvshowSeasonEpisodeUpsertRequest> service) : base(service)
        {

        }
    }
}