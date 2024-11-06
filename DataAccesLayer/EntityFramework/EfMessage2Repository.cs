using DataAccesLayer.abstracct;
using DataAccesLayer.concrete;
using DataAccesLayer.Repositories;
using EntityLayer.concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    public class EfMessage2Repository:GenericRepository<Mesajlar>,IMessage2Dal
    {
        public List<Mesajlar> GetListWithMessageByWriter(int id)
        {

            using (var c = new Context())
            {
                return c.Mesajlar.Include(x => x.SenderUser).Where(x => x.ReceiverId == id).ToList();
            }
        }
    }
}
