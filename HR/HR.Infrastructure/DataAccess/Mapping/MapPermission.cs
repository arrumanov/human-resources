using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping;
public class MapPermission : IEntityTypeConfiguration<Permission>
{
	public void Configure(EntityTypeBuilder<Permission> builder)
	{
		builder.HasKey(e => e.Id);
		builder.Property(e => e.Id).ValueGeneratedNever();

		builder.Property(e => e.ObjectType)
			.HasConversion<string>()
			.HasMaxLength(100);

		builder.Property(e => e.RoleType)
			.HasConversion<string>()
			.HasMaxLength(100);

		builder.HasOne(item => item.Resource)
			.WithMany(item => item.Permissions)
			.HasForeignKey(e => e.ResourceId)
			.HasPrincipalKey(e => e.Id)
			.OnDelete(DeleteBehavior.ClientSetNull);
	}
}
