using Project.Core.Utilities.Result;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
   public interface IOpinionService
    {
        IDataResult<List<Opinion>> GetAll();
        IDataResult<Opinion> Get(int id);
        IResult Add(Opinion opinion);
        IResult Update(Opinion opinion);

        IResult Delete(Opinion opinion);


    }
}
