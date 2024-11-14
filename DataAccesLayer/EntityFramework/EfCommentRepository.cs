using DataAccesLayer.abstracct;
using DataAccesLayer.Repositories;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{       
    public class EfCommentRepository:GenericRepository<coments>,ICommentDal
    {

    }
}
