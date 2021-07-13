using Project.Core.Utilities.Result;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
  public   interface IWriterService
    {
        IDataResult<List<Writer>> GetAll();
        IDataResult<Writer> Get(int id);
        IResult Add(Writer writer);
        IResult Update(Writer writer);

        IResult Delete(Writer writer);
    }
}
