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
    public class NewsController :
        BaseCRUDController<Data.Model.News, NewsSearchRequest, NewsUpsertRequest, NewsUpsertRequest>
    {
        public NewsController
            (ICRUDService<Data.Model.News, NewsSearchRequest, NewsUpsertRequest, NewsUpsertRequest> service) : base(service)
        {

        }
    }
}