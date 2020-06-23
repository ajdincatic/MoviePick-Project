using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviePick.Data.Request;
using MoviePick.Interfaces;

namespace MoviePick.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendController : ControllerBase
    {
        public IRecommendService _service { get; set; }

        public RecommendController(IRecommendService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Data.Model.MovieAndTvshow> RecommendProduct([FromQuery]RecommendedSearchRequest mtvs)
        {
            return _service.RecommendProduct(mtvs.MTVSID);
        }
    }
}