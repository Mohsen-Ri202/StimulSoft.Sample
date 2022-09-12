using Microsoft.EntityFrameworkCore;

namespace StimulSoft.Sample.Models
{
	public class MyAppDbContext:DbContext
	{
		public MyAppDbContext(DbContextOptions<MyAppDbContext> options):base(options)
		{

		}
		public DbSet<Vendor> Vendors { get; set; }
	}
}
