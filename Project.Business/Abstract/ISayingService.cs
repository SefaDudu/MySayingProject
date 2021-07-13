using Project.Core.Utilities.Result;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
    public interface ISayingService
    {
        IDataResult<List<Saying>> GetAll();
        IDataResult<Saying> Get(int id);
        IResult Add(Saying saying);
        IResult Update(Saying saying);

        IResult Delete(Saying saying);
    }
}
