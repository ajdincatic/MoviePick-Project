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
            var query = _context.MovieAndTvshow
                .Include(x => x.ProductionCompany)
                .Include("MovieAndTvshowGenre.Genre")
                .Include("MovieAndTvshowPerson.Role")
                .Include("MovieAndTvshowPerson.Person")
                .Include(x => x.TvshowSeason)
                .Include(x => x.Rating)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Title))
            {
                query = query.Where(x => x.Title.StartsWith(search.Title));
            }

            if (search?.ProductionCompanyId != null && search?.ProductionCompanyId != 0)
            {
                query = query.Where(x => x.ProductionCompanyId == search.ProductionCompanyId);
            }

            if (search?.isTvShow != null && search?.isTvShow == true)
            {
                query = query.Where(x => x.TvshowSeason.Count() != 0);
            }

            if (search?.isTvShow != null && search?.isTvShow != true)
            {
                query = query.Where(x => x.TvshowSeason.Count() == 0);
            }

            var mapper = _mapper.Map<List<Data.Model.MovieAndTvshow>>(query.ToList());
            foreach (var item in mapper)
            {
                if (item.Rating.Count() > 0)
                    item.CalculatedRating = item.Rating.Average(x => x.RatingValue).ToString();
                else
                    item.CalculatedRating = "0";
            }

            return mapper;
        }

        public override Data.Model.MovieAndTvshow GetById(int Id)
        {
            var x = _context.MovieAndTvshow
                .Include(x => x.TvshowSeason)
                .Where(x => x.Id == Id).SingleOrDefault();
            return _mapper.Map<Data.Model.MovieAndTvshow>(x);
        }

        public override Data.Model.MovieAndTvshow Insert(MovieAndTvshowUpsertRequest request)
        {
            var entity = _mapper.Map<Database.MovieAndTvshow>(request);

            _context.MovieAndTvshow.Add(entity);
            _context.SaveChanges();

            foreach (var genre in request.GenreIds)
            {
                Database.MovieAndTvshowGenre MTVGenre = new Database.MovieAndTvshowGenre();
                MTVGenre.MovieAndTvshowId = entity.Id;
                MTVGenre.GenreId = genre;
                _context.MovieAndTvshowGenre.Add(MTVGenre);
            }

            _context.SaveChanges();

            return _mapper.Map<Data.Model.MovieAndTvshow>(entity);
        }
    }
}
