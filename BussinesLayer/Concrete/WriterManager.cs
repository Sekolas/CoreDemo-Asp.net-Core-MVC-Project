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
		public void WriterAdd(Writer writer)
		{
			_writerdal.Insert(writer);
		}
	}
}
