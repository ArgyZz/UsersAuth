using Application.Interfaces.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Persistence
{
	public class EfCoreDbContext : DbContext , IEfCoreDbContext
	{

		public EfCoreDbContext(DbContextOptions<EfCoreDbContext> options)
			: base(options)
		{
		}
		public DbSet<User> Users { get; set; }
		public DbSet<UserRole> Roles { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<BookCategory> BookCategories { get; set; }

		public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) { }


	}
}
