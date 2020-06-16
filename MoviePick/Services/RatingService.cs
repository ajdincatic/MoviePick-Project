using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviePick.Data.Request;
using MoviePick.Database;
using MoviePick.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Services
{
    public class RatingService : IRatingService
    {
        protected MoviePickContext _context;
        protected IMapper _mapper;

        public RatingService(MoviePickContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Data.Model.Rating> Get(RatingSearchRequest request)
        {
            var query = _context.Rating
                .Include(x => x.MovieAndTvshow)
                .Include(x => x.MovieAndTvshow.Rating)
                .AsQueryable();

            if(request.MovieAndTvshowId != 0)
            {
                query = query.Where(x => x.MovieAndTvshowId == request.MovieAndTvshowId);
            }
            if (request.AppUserId != 0)
            {
                query = query.Where(x => x.AppUserId == request.AppUserId);
            }

            return _mapper.Map<List<Data.Model.Rating>>(query.ToList());
        }

        public Data.Model.Rating InsertRatingByUser(RatingUpsertRequest request)
        {
            var x = _context.Rating.Where(x => x.AppUserId == request.AppUserId && x.MovieAndTvshowId == request.MovieAndTvshowId).SingleOrDefault();
            if (x != null)
            {
                x.RatingValue = request.RatingValue;
                _context.SaveChanges();
                return _mapper.Map<Data.Model.Rating>(x);
            }
            else
            {
                var entity = _mapper.Map<Database.Rating>(request);
                _context.Rating.Add(entity);
                _context.MovieAndTvshow.Where(x => x.Id == request.MovieAndTvshowId).SingleOrDefault().NumberOfRatings++;
                _context.SaveChanges();
                return _mapper.Map<Data.Model.Rating>(entity);
            }
        }
    }
}
