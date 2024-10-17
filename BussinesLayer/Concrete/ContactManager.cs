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
    public class ContactManager : IContactService
    {
        IContactDal _conctactdal;

        public ContactManager(IContactDal contactdal)
        {
            _conctactdal = contactdal;
            
        }
        public void ContactAdd(Contact contact)
        {
            _conctactdal.Insert(contact);
        }
    }
}
