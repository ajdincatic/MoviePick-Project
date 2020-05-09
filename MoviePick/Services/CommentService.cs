using AutoMapper;
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
    }
}
