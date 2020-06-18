using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviePick.Database;
using MoviePick.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Services
{
    public class QuoteOfTheDay : IQuoteOfTheDay
    {
        protected MoviePickContext _context;

        private static Data.Model.Quote _quoteOfTheDay;
        private IMapper _mapper;

        public QuoteOfTheDay(MoviePickContext context, IMapper _mapper)
        {
            _context = context;
            this._mapper = _mapper;
        }

        public Data.Model.Quote GetRandomQuote()
        {
            return _quoteOfTheDay;
        }

        public Data.Model.Quote GenerateRandomQuote()
        {
            List<Quote> list = _context.Quote.Include(x => x.MovieAndTvshow).ToList();
            int[] listOfIds = list.Select(x => x.Id).ToArray();

            Random random = new Random();
            int position = random.Next(0, listOfIds.Count());

            _quoteOfTheDay = _mapper.Map<Data.Model.Quote>(list[position]);

            return _quoteOfTheDay;
        }
    }
}
