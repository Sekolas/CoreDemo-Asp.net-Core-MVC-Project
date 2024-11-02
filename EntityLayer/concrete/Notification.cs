using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string NotificationType{ get; set; }
        public string NotificationTypeSymbol{ get; set; }
        public string NotificationDetails { get; set; }
        public bool NotificaitonStatus { get; set; }
        public DateTime NotificaitonDate { get; set; }

        public bool NotificationColor { get; set; }

    }
}
