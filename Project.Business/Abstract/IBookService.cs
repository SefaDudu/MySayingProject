using Project.Core.Utilities.Result;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
    public interface IBookService
    {
        IDataResult<List<Book>> GetAll();
        IDataResult<Book> Get(int id);
        IResult Add(Book book);
        IResult Update(Book book);
       
        IResult Delete(Book book);

        
       

    }
}
