using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HR.Infrastructure.DataAccess;
public class HrContext : DbContext
{	
	public DbSet<Role> Roles { get; set; }
	public DbSet<User> Users { get; set; }
	public DbSet<UserJoinRole> UserJoinRole { get; set; }
	public DbSet<UserLanguage> UserLanguages { get; set; }

	public HrContext(DbContextOptions<HrContext> options)
	: base(options)
	{
		Database.EnsureCreated();
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
	}
}
