using Project.Business.Abstract;
using Project.Core.Utilities.Result;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerdal;
        public WriterManager(IWriterDal writerdal)
        {
            _writerdal = writerdal;
        }
        public IResult Add(Writer writer)
        {
             _writerdal.Add(writer);
            return new SuccessResult();
        }

        public IResult Delete(Writer writer)
        {
            _writerdal.Delete(writer);
            return new SuccessResult();
        }

        public IDataResult<Writer> Get(int id)
        {
            return new SuccessDataResult<Writer>(_writerdal.Get(x => x.ID == id));
        }

        public IDataResult<List<Writer>> GetAll()
        {
            return new SuccessDataResult<List<Writer>>(_writerdal.GetAll());
        }

        public IResult Update(Writer writer)
        {

            _writerdal.Update(writer);
            return new SuccessResult();
        }
    }
}
