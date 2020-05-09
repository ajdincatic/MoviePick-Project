using AutoMapper;
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
    public class MovieTvShowPersonService : IMovieTvShowPersonService
    {
        protected MoviePickContext _context;
        protected IMapper _mapper;

        public MovieTvShowPersonService(MoviePickContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Data.Model.MovieAndTvshowPerson AddPersonToMTVS(int mTVSId, MovieAndTvshowPersonUpsertRequest request)
        {
            var entity = _mapper.Map<Database.MovieAndTvshowPerson>(request);
            entity.MovieAndTvshowId = mTVSId;

            _context.MovieAndTvshowPerson.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Data.Model.MovieAndTvshowPerson>(entity);
        }

        public Data.Model.MovieAndTvshowPerson DeletePerson(int mtvsId, MovieAndTvshowDeleteRequest request)
        {
            var entity = _context.MovieAndTvshowPerson.Where(x => x.MovieAndTvshowId == mtvsId && x.PersonId == request.PersonId 
                && x.RoleId == request.RoleId).FirstOrDefault();
            if(entity != null)
            {
                _context.MovieAndTvshowPerson.Remove(entity);
                _context.SaveChanges();
                return _mapper.Map<Data.Model.MovieAndTvshowPerson>(entity);
            }
            return null;
        }

        public List<Data.Model.MovieAndTvshow> GetMTVSsbyPerson(int PersonId)
        {
            var query = _context.MovieAndTvshowPerson.AsQueryable();

            query = query.Where(x => x.PersonId == PersonId);

            var list = query.Select(x => x.MovieAndTvshow).ToList();

            return _mapper.Map<List<Data.Model.MovieAndTvshow>>(list);
        }

        public List<Data.Model.Person> GetPersonsByMTVS(int MTVSId, int RoleId)
        {
            var query = _context.MovieAndTvshowPerson.AsQueryable();

            query = query.Where(x => x.MovieAndTvshowId == MTVSId);

            if (RoleId != 0)
                query = query.Where(x => x.RoleId == RoleId);

            var list = query.Select(x => x.Person).ToList();

            return _mapper.Map<List<Data.Model.Person>>(list);
        }
    }
}
