using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
	public class CommentList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commenvalues = new List<UserComment>
			{
				new UserComment
				{
					ID = 1,
					Username = "melis",
				},
				new UserComment
				{
					ID = 2,
					Username = "ceren",
				},
				new UserComment
				{
					ID = 3,
					Username = "seren",
				}
			};
			return View(commenvalues); 
		}
	}
}
