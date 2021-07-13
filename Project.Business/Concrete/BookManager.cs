using Project.Business.Abstract;
using Project.Core.Utilities.Result;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public IResult Add(Book book)
        {
            _bookDal.Add(book);
            return new SuccessResult();
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);
            return new SuccessResult();
        }

        public IDataResult<Book> Get(int id)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(x=> x.ID == id));
        }

        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll());
        }

        public IResult Update(Book book)
        {
            _bookDal.Update(book);
            return new SuccessResult();
        }
    }
}
