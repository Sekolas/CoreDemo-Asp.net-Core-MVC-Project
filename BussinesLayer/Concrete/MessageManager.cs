using BussinesLayer.Abstract;
using DataAccesLayer.abstracct;
using DataAccesLayer.EntityFramework;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class MessageManager : ImessageService
    {
        IMessageDal _messageDal;
        public MessageManager(IMessageDal messagedal)
        {
            _messageDal = messagedal;
            
        }
        public List<Message> GetAll()
        {
            return _messageDal.GetListAll();
        }

        public List<Message> GetInboxWithByWriter(string p)
        {
            return _messageDal.GetListAll(x=>x.Receiver==p);

        }

        public void TAdd(Message t)
        {
            throw new NotImplementedException();
        }

        public Message TGetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Message t)
        {
            throw new NotImplementedException();
        }

        public void Update(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
