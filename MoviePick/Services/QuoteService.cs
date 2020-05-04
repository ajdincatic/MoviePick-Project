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
    public class QuoteService : BaseCRUDService<Data.Model.Quote, QuoteSearchRequest, QuoteUpsertRequest, QuoteUpsertRequest, Database.Quote>
    {
        public QuoteService(MoviePickContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Data.Model.Quote> Get(QuoteSearchRequest search)
        {
            var query = _context.Quote.Include(x => x.MovieAndTvshow).AsQueryable();

            if (search?.MovieAndTvshowId != null && search?.MovieAndTvshowId != 0)
            {
                query = query.Where(x => x.MovieAndTvshowId == search.MovieAndTvshowId);
            }

            return _mapper.Map<List<Data.Model.Quote>>(query.ToList());
        }
    }
}
