using Project.Business.Abstract;
using Project.Core.Utilities.Result;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class OpinionManager : IOpinionService
    {

        IOpinionDal _opinionDal;
        public OpinionManager(IOpinionDal opinionDal)
        {
            _opinionDal = opinionDal;
        }
        public IResult Add(Opinion opinion)
        {
            _opinionDal.Add(opinion);
            return new SuccessResult();
        }

        public IResult Delete(Opinion opinion)
        {
            _opinionDal.Delete(opinion);
            return new SuccessResult();
        }

        public IDataResult<Opinion> Get(int id)
        {
            return new SuccessDataResult<Opinion>(_opinionDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Opinion>> GetAll()
        {
            return new SuccessDataResult<List<Opinion>>(_opinionDal.GetAll());

        }

        public IResult Update(Opinion opinion)
        {
            _opinionDal.Update(opinion);
            return new SuccessResult();
        }
    }
}
