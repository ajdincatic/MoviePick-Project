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
    public class GenreMovieTvShowService : BaseService<Data.Model.MovieTvShowGenre, GenreMovieTvShowSearchRequest, Database.MovieAndTvshowGenre>
    {
        public GenreMovieTvShowService(MoviePickContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<MovieTvShowGenre> Get(GenreMovieTvShowSearchRequest search)
        {
            var query = _context.MovieAndTvshowGenre
                .Include("Genre")
                .Include("MovieAndTvshow")
                .Include(x => x.MovieAndTvshow.ProductionCompany)
                .AsQueryable();

            if (search?.MovieAndTvshowId != 0)
            {
                query = query.Where(x => x.MovieAndTvshowId == search.MovieAndTvshowId);
            }
            if (search?.GenreId != 0)
            {
                query = query.Where(x => x.GenreId == search.GenreId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Data.Model.MovieTvShowGenre>>(list);
        }

    }
}
