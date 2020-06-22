using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Services;
using Microsoft.EntityFrameworkCore;
using MoviePick.Data.Request;
using MoviePick.Database;

namespace MoviePick.Services
{
    public class PersonService :
        BaseCRUDService<Data.Model.Person, PersonSearchRequest, PersonUpsertRequest, PersonUpsertRequest, Database.Person>
    {
        public PersonService(MoviePickContext _context, IMapper _mapper) : base(_context, _mapper)
        {
        }

        public override List<Data.Model.Person> Get(PersonSearchRequest search)
        {
            var query = _context.Person
                .Include("MovieAndTvshowPerson.MovieAndTvshow")
                .Include("MovieAndTvshowPerson.Role")
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.FirstName))
            {
                query = query.Where(x => x.FirstName.ToLower().StartsWith(search.FirstName.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search?.LastName))
            {
                query = query.Where(x => x.LastName.ToLower().StartsWith(search.LastName.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search?.Gender))
            {
                query = query.Where(x => x.Gender.StartsWith(search.Gender));
            }

            return _mapper.Map<List<Data.Model.Person>>(query.ToList());
        }

    }
}
