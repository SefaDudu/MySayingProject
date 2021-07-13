using Project.Core.Utilities.Result;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
   public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> Get(int id);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        bool LoginCheck(string username, string password);
    }
}
