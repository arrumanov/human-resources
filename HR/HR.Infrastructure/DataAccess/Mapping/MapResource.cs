using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping;
public class MapResource : IEntityTypeConfiguration<Resource>
{
	public void Configure(EntityTypeBuilder<Resource> builder)
	{
		builder.HasKey(e => e.Id);
		builder.Property(e => e.Id).ValueGeneratedNever();
		builder.Property(e => e.Rate).HasColumnType("decimal(18,4)");

		builder.HasMany(e => e.ResourceKeys)
			.WithOne()
			.HasForeignKey(e => e.ResourceId)
			.OnDelete(DeleteBehavior.Cascade);
		builder.HasMany(e => e.ResourceColors)
			.WithOne()
			.HasForeignKey(e => e.ObjectId)
			.OnDelete(DeleteBehavior.Cascade);
		builder.HasMany(e => e.Favorites)
			.WithOne()
			.HasForeignKey(e => e.ObjectId)
			.OnDelete(DeleteBehavior.Cascade);
		builder.HasMany(e => e.CustomFieldValues)
			.WithOne()
			.HasForeignKey(e => e.ObjectId)
			.HasPrincipalKey(e => e.Id)
			.OnDelete(DeleteBehavior.Cascade);
		builder.HasMany(e => e.Translations)
			.WithOne()
			.HasForeignKey(e => e.ObjectId)
			.HasPrincipalKey(e => e.Id)
			.OnDelete(DeleteBehavior.Cascade);
		builder.HasOne(item => item.Department)
			.WithMany()
			.HasForeignKey(item => item.DepartmentId)
			.HasPrincipalKey(item => item.Id)
			.OnDelete(DeleteBehavior.ClientSetNull);
		builder.HasOne(item => item.UpperUnit)
			.WithMany()
			.HasForeignKey(item => item.UpperUnitId)
			.HasPrincipalKey(item => item.Id)
			.OnDelete(DeleteBehavior.ClientSetNull);
		builder.HasOne(item => item.Position)
			.WithMany()
			.HasForeignKey(item => item.PositionId)
			.HasPrincipalKey(item => item.Id)
			.OnDelete(DeleteBehavior.ClientSetNull);
		builder.HasOne(item => item.Status)
			.WithMany()
			.HasForeignKey(item => item.StatusId)
			.HasPrincipalKey(item => item.Id)
			.OnDelete(DeleteBehavior.ClientSetNull);
		builder.HasOne(item => item.ResourceManager)
			.WithMany()
			.HasForeignKey(item => item.ResourceManagerId)
			.HasPrincipalKey(item => item.Id)
			.OnDelete(DeleteBehavior.ClientSetNull);
		builder.HasMany(e => e.PermissionsForObject)
			.WithOne(e => e.ObjectResource)
			.HasForeignKey(e => e.ObjectId)
			.HasPrincipalKey(e => e.Id)
			.OnDelete(DeleteBehavior.Cascade);
	}
}
