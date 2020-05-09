using AutoMapper;
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
            var query = _context.Rating.AsQueryable();

            if(request.AppUserId != 0)
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
            var entity = _mapper.Map<Database.Rating>(request);

            _context.Rating.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Data.Model.Rating>(entity);
        }
    }
}
