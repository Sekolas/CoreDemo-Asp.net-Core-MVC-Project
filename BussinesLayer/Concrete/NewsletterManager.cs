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
    public class NewsletterManager : InewsletterService
    {

        INewsletterdal _ınewsletterdal;
        private EfNewsletterRepository efNewsletterRepository;

        public NewsletterManager(INewsletterdal newsletterdal)
        {
            _ınewsletterdal = newsletterdal;
            
        }

        public NewsletterManager(EfNewsletterRepository efNewsletterRepository)
        {
            this.efNewsletterRepository = efNewsletterRepository;
        }

        public void AddNewsLetter(NewsLetter newsLetter)
        {

            _ınewsletterdal.Insert(newsLetter);  

        }
    }
}
