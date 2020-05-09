using MoviePick.Data.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Interfaces
{
    public interface IRatingService
    {
        List<Data.Model.Rating> Get(RatingSearchRequest request);
        Data.Model.Rating InsertRatingByUser(RatingUpsertRequest request);
    }
}
