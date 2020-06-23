using MoviePick.Data.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Interfaces
{
    public interface IRecommendService
    {
        List<Data.Model.MovieAndTvshow> RecommendProduct(int mtvs);
    }
}
