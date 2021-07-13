using Project.Core.Utilities.Result;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
   public interface IPublisherService
    {
        IDataResult<List<Publisher>> GetAll();
        IDataResult<Publisher> Get(int id);
        IResult Add(Publisher publisher);
        IResult Update(Publisher publisher);

        IResult Delete(Publisher publisher);
    }
}
