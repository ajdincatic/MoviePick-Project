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
    public class QuoteController 
        : BaseCRUDController<Data.Model.Quote, QuoteSearchRequest, QuoteUpsertRequest, QuoteUpsertRequest>
    {
        public QuoteController(ICRUDService<Data.Model.Quote, QuoteSearchRequest, QuoteUpsertRequest, QuoteUpsertRequest> service) : base(service)
        {

        }
    }
}