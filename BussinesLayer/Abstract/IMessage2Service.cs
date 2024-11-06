using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
    public interface IMessage2Service:IgenericService<Mesajlar>
    {
        List<Mesajlar> GetInboxWithByWriter(int p);

    }

}
