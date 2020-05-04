using AutoMapper;
using eProdaja.Services;
using Microsoft.EntityFrameworkCore;
using MoviePick.Data.Request;
using MoviePick.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Services
{
    public class MovieAndTvShowService :
        BaseCRUDService<Data.Model.MovieAndTvshow, MovieAndTvshowSearchRequest, MovieAndTvshowUpsertRequest, MovieAndTvshowUpsertRequest, Database.MovieAndTvshow>
    {
        public MovieAndTvShowService(MoviePickContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Data.Model.MovieAndTvshow> Get(MovieAndTvshowSearchRequest search)
        {
            var query = _context.MovieAndTvshow.Include(x => x.ProductionCompany).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Title))
            {
                query = query.Where(x => x.Title.StartsWith(search.Title));
            }


            return _mapper.Map<List<Data.Model.MovieAndTvshow>>(query.ToList());
        }
    }
}
