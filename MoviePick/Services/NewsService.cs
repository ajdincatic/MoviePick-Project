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
    public class NewsService :
        BaseCRUDService<Data.Model.News, NewsSearchRequest, NewsUpsertRequest, NewsUpsertRequest, Database.News>
    {
        public NewsService(MoviePickContext _context, IMapper _mapper) : base(_context, _mapper)
        {
        }

        public override List<Data.Model.News> Get(NewsSearchRequest search)
        {
            var query = _context.News.Include(x => x.Author).Include(x => x.MovieAndTvshowNews).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Title))
            {
                query = query.Where(x => x.Title.StartsWith(search.Title));
            }

            if (search?.AuthorId != null && search?.AuthorId != 0)
            {
                query = query.Where(x => x.AuthorId == search.AuthorId);
            }

            return _mapper.Map<List<Data.Model.News>>(query.ToList());
        }

        public override Data.Model.News Insert(NewsUpsertRequest request)
        {
            var entity = _mapper.Map<Database.News>(request);

            _context.News.Add(entity);
            _context.SaveChanges();

            if (request.MoveTvShowIds != null)
            {
                foreach (var movie in request.MoveTvShowIds)
                {
                    Database.MovieAndTvshowNews MTVsNews = new Database.MovieAndTvshowNews();
                    MTVsNews.NewsId = entity.Id;
                    MTVsNews.MovieAndTvshowId = movie;
                    _context.MovieAndTvshowNews.Add(MTVsNews);
                }

                _context.SaveChanges();
            }

            return _mapper.Map<Data.Model.News>(entity);
        }
    }
}
