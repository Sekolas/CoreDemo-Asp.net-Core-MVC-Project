using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CoreDemo.Controllers
{
	public class EmployeeController : Controller
	{

		public async Task<IActionResult> Index()
		{
			var httpClient = new HttpClient();
			var responseMessage = await httpClient.GetAsync("https://localhost:7141/api/Default");
			var jsınString = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<class1>>(jsınString);
			return View(values);
		}
		[HttpGet]
		public IActionResult AddEmployee()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> AddEmployee(class1 p)
		{
			var httpClient = new HttpClient();
			var jsonemp = JsonConvert.SerializeObject(p);
			StringContent content = new StringContent(jsonemp, Encoding.UTF8, "application/json");
			var responMessage = await httpClient.PostAsync("https://localhost:7141/api/Default", content);
			if (responMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View(p);


		}
		[HttpGet]

		public async Task<IActionResult> EditEmployee(int id)
		{

			var httpClient = new HttpClient();
			var response=await httpClient.GetAsync("https://localhost:7141/api/Default/" + id);
			if (response.IsSuccessStatusCode)
			{
				var jsonemp=await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<class1>(jsonemp);
				return View(values);
			}
			return RedirectToAction("Index");

		}
		[HttpPost]
		public async Task<IActionResult> EditEmployee(class1 p) {
			var httpClient = new HttpClient();
			var jsonemployee = JsonConvert.SerializeObject(p);
			var content = new StringContent(jsonemployee, Encoding.UTF8, "application/json");
			var responMessage = await httpClient.PutAsync("https://localhost:7141/api/Default", content);
			if (responMessage.IsSuccessStatusCode) { 
				return RedirectToAction("Index");
			}
			return View(p);
		}

		public async Task<IActionResult> DeleteEmpLoyee(int id)
		{
			var httpClient = new HttpClient();
			var response = await httpClient.DeleteAsync("https://localhost:7141/api/Default/" + id);
			if (response.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();

		}
		

	}
	public class class1
	{

		public int ID { get; set; }
		public string Name { get; set; }
	}
}
