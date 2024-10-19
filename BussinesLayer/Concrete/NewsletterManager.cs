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

        INewsletterdal _newsletterdal;
        private EfNewsletterRepository efNewsletterRepository;

        public NewsletterManager(INewsletterdal newsletterdal)
        {
            _newsletterdal = newsletterdal;
            
        }

        public NewsletterManager(EfNewsletterRepository efNewsletterRepository)
        {
            this.efNewsletterRepository = efNewsletterRepository;
        }

        public void AddNewsLetter(NewsLetter newsLetter)
        {

            _newsletterdal.Insert(newsLetter);  

        }
    }
}
