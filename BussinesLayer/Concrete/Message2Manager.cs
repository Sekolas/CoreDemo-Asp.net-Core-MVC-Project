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
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal _messagedal;
        public Message2Manager(IMessage2Dal mmessagedal)
        {
            _messagedal = mmessagedal;
            
        }
        public List<Mesajlar> GetAll()
        {
            return _messagedal.GetListAll();


        }

        public List<Mesajlar> GetInboxWithByWriter(int id)
        {
            return _messagedal.GetListWithMessageByWriter(id);

        }


        public void TAdd(Mesajlar t)
        {
            throw new NotImplementedException();
        }

        public Mesajlar TGetbyId(int id)
        {
            return _messagedal.GetById(id);
        }

        public void TRemove(Mesajlar t)
        {
            throw new NotImplementedException();
        }

        public void Update(Mesajlar t)
        {
            throw new NotImplementedException();
        }
    }
}
