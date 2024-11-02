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
    public class NotificationManager : INotificationService
    {
        INotificaitonDal _notificaitondal;

        public NotificationManager(INotificaitonDal notificaitonDal)
        {
            _notificaitondal = notificaitonDal;
            
        }
        public List<Notification> GetAll()
        {
          return _notificaitondal.GetListAll();
        }

        public void TAdd(Notification t)
        {
            throw new NotImplementedException();
        }

        public Notification TGetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Notification t)
        {
            throw new NotImplementedException();
        }

        public void Update(Notification t)
        {
            throw new NotImplementedException();
        }
    }
}
