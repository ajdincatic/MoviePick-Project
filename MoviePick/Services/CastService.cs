using AutoMapper;
using eProdaja.Services;
using Microsoft.EntityFrameworkCore;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
using MoviePick.Database;
using MoviePick.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Services
{
    public class CastService :
        BaseCRUDService<Data.Model.MovieAndTvshowPerson, MovieAndTvshowPersonSearchRequest, MovieAndTvshowPersonUpsertRequest, MovieAndTvshowPersonUpsertRequest, Database.MovieAndTvshowPerson>
    {
        public CastService(MoviePickContext context, IMapper mapper) : base(context,mapper)
        {
        }

        public override List<Data.Model.MovieAndTvshowPerson> Get(MovieAndTvshowPersonSearchRequest request)
        {
            var query = _context.MovieAndTvshowPerson
                .Include(x => x.MovieAndTvshow).Include(x => x.Person).Include(x => x.Role).AsQueryable();

            if (request?.RoleId != 0)
            {
                query = query.Where(x => x.RoleId == request.RoleId);
            }
            if (request?.MovieAndTvshowId != 0)
            {
                query = query.Where(x => x.MovieAndTvshowId == request.MovieAndTvshowId);
            }
            if (request?.PersonId != 0)
            {
                query = query.Where(x => x.PersonId == request.PersonId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Data.Model.MovieAndTvshowPerson>>(list);
        }

    }
}
