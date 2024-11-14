using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
	public interface ICommentService
	{
		void AddComment(coments  category);
		//void RemoveCategory(Category category);
		//void CategoryUpdate(Category category);
		List<coments> Getlist(int id);
	}
}
