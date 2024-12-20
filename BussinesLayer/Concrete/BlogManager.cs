﻿using BussinesLayer.Abstract;
using DataAccesLayer.abstracct;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class BlogManager : IBlogService
	{
		IBlogDal _blogdal;

        public BlogManager(IBlogDal blogdal)
        {
            _blogdal=blogdal;
        }

        public List<Blog> GetAll()
        {
            return _blogdal.GetListAll();
        }

        public List<Blog> GetBlockWithCategory()
        {
            return _blogdal.GetListWithCategory();
        }
        public List<Blog> Test(int id)
        {
            return _blogdal.GetListWithoutCategoryByWriter(id);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogdal.GetListAll(x => x.WriterID == id);
        }

        public Blog TGetbyId(int id)
        {
            return _blogdal.GetById(id);
        }

        public void TAdd(Blog t)
        {
            _blogdal.Insert(t);
        }

        public void TRemove(Blog t)
        {
            _blogdal.Delete(t);
        }

        public void Update(Blog t)
        {
           _blogdal.Update(t);
        }
        public List<Blog> GetLast3Blog()
        {
            return _blogdal.GetListAll().Take(3).ToList();
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogdal.GetListAll(x => x.BlogId == id);
        }
    }
}
