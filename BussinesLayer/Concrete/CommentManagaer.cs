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
	public class CommentManagaer : ICommentService
	{
		ICommentDal _commendtdal;

        public CommentManagaer(ICommentDal commentdal)
        {
			_commendtdal = commentdal;
            
        }
        public void AddComment(Comment comment)
		{
			_commendtdal.Insert(comment);
		}

		public List<Comment> Getlist(int id)
		{
			return _commendtdal.GetListAll(x => x.BlogId == id);
		}

		
	}
}
