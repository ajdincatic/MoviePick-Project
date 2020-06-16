using MoviePick.Data.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Interfaces
{
    public interface ICommentService
    {
        public List<Data.Model.Comment> Get(CommentSearchRequest request);
        public Data.Model.Comment Insert(CommentUpsertRequest request);
    }
}
