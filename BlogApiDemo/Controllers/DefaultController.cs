using BlogApiDemo.Controllers.DataAccesLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApiDemo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DefaultController : ControllerBase
	{
		[HttpGet] 
		public IActionResult EmployeList()
		{
			using var c = new Context();
			var values = c.Employees.ToList();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult EmployeEAdd(Employee empployee)
		{
			using var c = new Context();
			c.Add(empployee);
			c.SaveChanges();
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult EmployeGet(int id)
		{
			using var c = new Context();
			var employee = c.Employees.Find(id);
			if (employee != null)
			{

				return Ok(employee);
			}
			else {
				return NotFound();
			}
			
		}
		[HttpDelete("{id}")]
		public IActionResult EmployeeDelete(int id)
		{
			using var c = new Context();
			var employee=c.Employees.Find(id);
			if (employee != null) { 
				c.Remove(employee);
				c.SaveChanges();
				return Ok();
			
			}
			else
			{
				return NotFound();

			}
		}

		[HttpPut]
		public IActionResult EmployeeUpdate(Employee employee)
		{
			using var c=new Context();
			var employees = c.Find<Employee>(employee.ID);
			if (employees != null)
			{
				employees.Name=employee.Name;
				c.Update(employees);
				c.SaveChanges();
				return Ok();
			}
			else { 
				return NotFound(); 
			}

		}

	}
}
