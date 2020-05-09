using MoviePick.Data.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Interfaces
{
    public interface IMovieTvShowPersonService
    {
        List<Data.Model.MovieAndTvshow> GetMTVSsbyPerson(int PersonId);
        List<Data.Model.Person> GetPersonsByMTVS(int MTVSId, int RoleId);
        Data.Model.MovieAndTvshowPerson AddPersonToMTVS(int mTVSId, MovieAndTvshowPersonUpsertRequest request);
        Data.Model.MovieAndTvshowPerson DeletePerson(int MTVSId, MovieAndTvshowDeleteRequest request);
    }
}
