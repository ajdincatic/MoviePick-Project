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
    public class TvshowSeasonService :
        BaseCRUDService<Data.Model.TvshowSeason, TvshowSeasonSearchRequest, TvshowSeasonUpsertRequest, TvshowSeasonUpsertRequest, Database.TvshowSeason>
    {
        public TvshowSeasonService(MoviePickContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Data.Model.TvshowSeason> Get(TvshowSeasonSearchRequest search)
        {
            var query = _context.TvshowSeason.Include(x => x.MovieAndTvshow).AsQueryable();

            if (search?.MovieAndTvshowId != null && search?.MovieAndTvshowId != 0)
            {
                query = query.Where(x => x.MovieAndTvshowId == search.MovieAndTvshowId);
            }

            return _mapper.Map<List<Data.Model.TvshowSeason>>(query.ToList());
        }
    }
}
