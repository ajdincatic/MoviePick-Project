using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TModel, TSearch> : ControllerBase
    {
        private readonly IService<TModel, TSearch> _service;

        public BaseController(IService<TModel, TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public List<TModel> GetAll([FromQuery] TSearch search)
        {
            return _service.Get(search);
        }

        [HttpGet("{Id}")]
        public TModel GetById(int Id)
        {
            return _service.GetById(Id);
        }
    }
}