using BussinesLayer.Abstract;
using DataAccesLayer.abstracct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
	public class AdminManagewr:IadminService
	{
		IAdminDal _admnindal;
        public AdminManagewr(IAdminDal admindal)
        {
            _admnindal = admindal;
            
        }

    }
}
