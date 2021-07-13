using Project.Business.Abstract;
using Project.Core.Utilities.Result;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class SayingManager : ISayingService
    {

        ISayingDal _sayingDal;
        public SayingManager(ISayingDal sayingDal)
        {
            _sayingDal = sayingDal;
        }
        public IResult Add(Saying saying)
        {
            _sayingDal.Add(saying);
            return new SuccessResult();
        }

        public IResult Delete(Saying saying)
        {
            _sayingDal.Delete(saying);
            return new SuccessResult();
        }

        public IDataResult<Saying> Get(int id)
        {
            return new SuccessDataResult<Saying>(_sayingDal.Get(x => x.ID == id));
        }

        public IDataResult<List<Saying>> GetAll()
        {
            return new SuccessDataResult<List<Saying>>(_sayingDal.GetAll());
        }

        public IResult Update(Saying saying)
        {
            _sayingDal.Update(saying);
            return new SuccessResult();
        }
    }
}
