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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutdal;

        public AboutManager(IAboutDal aboutdal)
        {
            _aboutdal = aboutdal;
            
        }
        public List<About> Getlist()
        {
           return  _aboutdal.GetListAll();        }


    }
}
