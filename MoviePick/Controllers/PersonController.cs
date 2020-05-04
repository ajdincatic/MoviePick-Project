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
    public class PersonController : 
        BaseCRUDController<Data.Model.Person, PersonSearchRequest, PersonUpsertRequest, PersonUpsertRequest>
    {
        public PersonController
            (ICRUDService<Data.Model.Person, PersonSearchRequest, PersonUpsertRequest, PersonUpsertRequest> service) : base(service)
        {

        }
    }
}