using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Interfaces
{
    public interface IGenreMovieTvShowService
    {
        List<Data.Model.Genre> GetGenresByMTVS(int MTVSId);
        List<Data.Model.MovieAndTvshow> GetMTVSByGenre(int GenreId);
    }
}
