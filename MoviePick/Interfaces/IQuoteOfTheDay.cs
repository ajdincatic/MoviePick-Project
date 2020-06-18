using MoviePick.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Interfaces
{
    public interface IQuoteOfTheDay
    {
        Data.Model.Quote GenerateRandomQuote();
        Data.Model.Quote GetRandomQuote();
    }
}
