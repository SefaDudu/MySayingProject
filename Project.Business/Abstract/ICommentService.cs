using Project.Core.Utilities.Result;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
    public interface ICommentService
    {
        IDataResult<List<Comment>> GetAll();
        IDataResult<List<Comment>> GetAllWithQuery(int bookId);
        IDataResult<Comment> Get(int id);
        IResult Add(Comment comment);
        IResult Update(Comment comment);

        IResult Delete(Comment comment);
    }
}
