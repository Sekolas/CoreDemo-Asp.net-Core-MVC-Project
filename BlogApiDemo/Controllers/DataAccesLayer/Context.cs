using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.Controllers.DataAccesLayer
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=LAPTOP-I0QS5ARU;initial Catalog=CoreApiDb;integrated Security=true;TrustServerCertificate=True");

		}
		public DbSet<Employee> Employees { get; set; } 
	}
}
