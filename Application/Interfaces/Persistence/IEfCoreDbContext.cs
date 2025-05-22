using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Persistence
{
	public interface IEfCoreDbContext
	{

		DbSet<User> Users { get; set; }
		DbSet<UserRole> Roles { get; set; }
		DbSet<Book> Books { get; set; }
		DbSet<BookCategory> BookCategories { get; set; }

		Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

	}
}
