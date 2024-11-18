using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
	public class Admin
	{
		[Key]
		public int AdminId { get; set; }
		public string Username{ get; set; }
		public string Password{ get; set; }

		public string Name{ get; set; }
		public string ShortDesc { get; set; }
		public string ImageUrl{ get; set; }
		public string Role { get; set; }


	}
}
