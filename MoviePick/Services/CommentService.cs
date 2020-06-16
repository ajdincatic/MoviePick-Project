using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
    public class CommentService : ICommentService
    {
        protected MoviePickContext _context;
        protected IMapper _mapper;

        public CommentService(MoviePickContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Data.Model.Comment> Get(CommentSearchRequest request)
        {
            var query = _context.Comment
                .Include(x => x.AppUser)
                .AsQueryable();

            if (request.MovieAndTvshowId != 0)
            {
                query = query.Where(x => x.MovieAndTvshowId == request.MovieAndTvshowId);
            }
            if (request.AppUserId != 0)
            {
                query = query.Where(x => x.AppUserId == request.AppUserId);
            }

            return _mapper.Map<List<Data.Model.Comment>>(query.ToList());
        }

        public Data.Model.Comment Insert(CommentUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Comment>(request);
            _context.Comment.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Data.Model.Comment>(entity);
        }
    }
}
