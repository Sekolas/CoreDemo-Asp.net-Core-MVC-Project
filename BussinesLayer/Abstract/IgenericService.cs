using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
    public interface IgenericService<T>
    {
        void TAdd(T t);
        void TRemove(T t);
        void Update(T t);
        List<T> GetAll();
        T GetbyId(int id);
    }
}
