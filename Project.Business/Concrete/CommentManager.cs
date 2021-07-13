using Project.Business.Abstract;
using Project.Core.Utilities.Result;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
          
        public IResult Add(Comment comment)
        {
            _commentDal.Add(comment);
            return new SuccessResult();
        }

        public IResult Delete(Comment comment)
        {
            _commentDal.Delete(comment);
            return new SuccessResult();
        }

        public IDataResult<Comment> Get(int id)
        {
            return new SuccessDataResult<Comment>(_commentDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Comment>> GetAll()
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll());

        }

        public IDataResult<List<Comment>> GetAllWithQuery(int bookId)
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(x=>x.BookId == bookId));

        }

        public IResult Update(Comment comment)
        {
            _commentDal.Update(comment);
            return new SuccessResult();
        }
    }
}
