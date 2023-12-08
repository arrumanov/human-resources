using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HR.Infrastructure.DataAccess;
public class HrContext : DbContext
{	
	public DbSet<Color> Colors { get; set; }
	public DbSet<CustomField> CustomFields { get; set; }
	public DbSet<CustomFieldReference> CustomFieldReferences { get; set; }
	public DbSet<CustomFieldValue> CustomFieldValues { get; set; }
	public DbSet<CustomFieldValueLanguage> CustomFieldValueLanguages { get; set; }
	public DbSet<Dictionary> Dictionaries { get; set; }
	public DbSet<DictionaryValue> DictionaryValues { get; set; }
	public DbSet<DictionaryValueUniqKey> DictionaryValueUniqKeys { get; set; }
	public DbSet<Favorite> Favorites { get; set; }
	public DbSet<HeadOfDepartment> HeadsOfDepartments { get; set; }
	public DbSet<ObjectColor> ObjectColors { get; set; }
	public DbSet<Permission> Permissions { get; set; }
	public DbSet<Resource> Resources { get; set; }
	public DbSet<ResourceUniqKey> ResourceUniqKeys { get; set; }
	public DbSet<Role> Roles { get; set; }
	public DbSet<Translation> Translations { get; set; }
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
