using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    public class BaseCRUDController<TModel, TSearch, TInsert, TUpdate> : BaseController<TModel, TSearch>
    {
        private readonly ICRUDService<TModel, TSearch, TInsert, TUpdate> _service = null;
        public BaseCRUDController(ICRUDService<TModel, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public TModel Post(TInsert request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{Id}")]
        public TModel Update(int Id, [FromBody]TUpdate request)
        {
            return _service.Update(Id, request);
        }
    }
}