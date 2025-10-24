namespace Nhu_211242485_de01.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options) { }

		public DbSet<Computer> Computers { get; set; }
	}
}
