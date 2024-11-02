
using DataAccesLayer.abstracct;
using DataAccesLayer.Repositories;
using EntityLayer.concrete;


namespace DataAccesLayer.EntityFramework
{
    public class EfNoticitaionRepository : GenericRepository<Notification>, INotificaitonDal
    {

    }
}
