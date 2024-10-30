using BussinesLayer.Abstract;
using DataAccesLayer.abstracct;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class WriterManager : IwriterService
	{
		IWriterDal _writerdal;

		public WriterManager(IWriterDal writerDal)
		{
			_writerdal = writerDal;

		}

        public List<Writer> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerdal.GetListAll(x => x.WriterID == id);
        }

        public void TAdd(Writer t)
        {
            _writerdal.Insert(t);
        }

        public Writer TGetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Writer t)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer t)
        {
            throw new NotImplementedException();
        }

        

	}
}
