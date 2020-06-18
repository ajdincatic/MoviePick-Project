using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviePick.Data.Model;
using MoviePick.Interfaces;

namespace MoviePick.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteOfTheDayController : ControllerBase
    {
        private readonly IQuoteOfTheDay _service;

        public QuoteOfTheDayController(IQuoteOfTheDay _service)
        {
            this._service = _service;
        }

        [HttpGet]
        public Data.Model.Quote GetRandomQuote()
        {
            return _service.GetRandomQuote();
        }

        [NonAction]
        public Data.Model.Quote GenerateRandomQuote()
        {
            return _service.GenerateRandomQuote();
        }
    }
}