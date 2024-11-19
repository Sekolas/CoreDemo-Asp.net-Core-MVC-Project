using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreDemo.Controllers
{
	public class EmployTestController : Controller
	{
		public async Task<IActionResult> Index()
		{
			var httpClient=new HttpClient();
			var responseMessage = await httpClient.GetAsync("https://localhost:7141/api/Default");
			var jsınString=await responseMessage.Content.ReadAsStringAsync();
			var values=JsonConvert.DeserializeObject<List<class1>>(jsınString);
			return View(values);
		}

		
	}
	public class class1
	{
		public int ID { get; set; }
		public string Name { get; set; }

	}
}
