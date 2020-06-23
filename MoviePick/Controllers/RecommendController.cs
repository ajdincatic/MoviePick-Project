using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviePick.Data.Request;

namespace MoviePick.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendController : ControllerBase
    {
        public IMapper _mapper { get; set; }
        public RecommendController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public List<Data.Model.MovieAndTvshow> RecommendProduct([FromQuery]RecommendedSearchRequest mtvs)
        {
            Recomender r = new Recomender();
            return _mapper.Map<List<Data.Model.MovieAndTvshow>>(r.LoadSimilar(mtvs.MTVSID));
        }
    }
}