using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Controllers;
using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoviePick.Controllers
{
    public class ProductionCompanyController : BaseController<Data.Model.ProductionCompany, object>
    {
        public ProductionCompanyController(IService<Data.Model.ProductionCompany, object> service) : base(service)
        {

        }
    }
}