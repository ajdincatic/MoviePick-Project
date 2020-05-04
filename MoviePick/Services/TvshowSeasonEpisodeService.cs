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
    public class TvshowSeasonEpisodeService :
        BaseCRUDService<Data.Model.TvshowSeasonEpisode, TvshowSeasonEpisodeSearchRequest, TvshowSeasonEpisodeUpsertRequest, TvshowSeasonEpisodeUpsertRequest, Database.TvshowSeasonEpisode>
    {
        public TvshowSeasonEpisodeService(MoviePickContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Data.Model.TvshowSeasonEpisode> Get(TvshowSeasonEpisodeSearchRequest search)
        {
            var query = _context.TvshowSeasonEpisode.Include(x => x.TvshowSeason).ThenInclude(x => x.MovieAndTvshow).AsQueryable();

            if (search?.TvshowSeasonId != null && search?.TvshowSeasonId != 0)
            {
                query = query.Where(x => x.TvshowSeasonId == search.TvshowSeasonId);
            }

            return _mapper.Map<List<Data.Model.TvshowSeasonEpisode>>(query.ToList());
        }
    }
}
