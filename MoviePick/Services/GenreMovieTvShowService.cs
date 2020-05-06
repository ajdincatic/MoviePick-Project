using AutoMapper;
using MoviePick.Data.Model;
using MoviePick.Database;
using MoviePick.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Services
{
    public class GenreMovieTvShowService : IGenreMovieTvShowService
    {
        protected MoviePickContext _context;
        protected IMapper _mapper;

        public GenreMovieTvShowService(MoviePickContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Data.Model.Genre> GetGenresByMTVS(int MTVSId)
        {
            var query = _context.MovieAndTvshowGenre.AsQueryable();

            query = query.Where(x => x.MovieAndTvshowId == MTVSId);

            var list = query.Select(x => x.Genre).ToList();

            return _mapper.Map<List<Data.Model.Genre>>(list);
        }

        public List<Data.Model.MovieAndTvshow> GetMTVSByGenre(int GenreId)
        {
            var query = _context.MovieAndTvshowGenre.AsQueryable();

            query = query.Where(x => x.GenreId == GenreId);

            var list = query.Select(x => x.MovieAndTvshow).ToList();

            return _mapper.Map<List<Data.Model.MovieAndTvshow>>(list);
        }
    }
}
