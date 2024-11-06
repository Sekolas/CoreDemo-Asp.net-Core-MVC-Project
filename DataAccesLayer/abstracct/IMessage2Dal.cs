using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.abstracct
{
    public interface IMessage2Dal : IGenericDal<Mesajlar>
    {
        List<Mesajlar> GetListWithMessageByWriter(int id);

    }
}
