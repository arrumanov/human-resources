using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping;
public class MapUserJoinRole : IEntityTypeConfiguration<UserJoinRole>
{
	public void Configure(EntityTypeBuilder<UserJoinRole> builder)
	{
		builder.HasKey(e => new { e.RoleId, e.UserId });

		builder.HasOne(d => d.Role)
			.WithMany()
			.OnDelete(DeleteBehavior.ClientSetNull);
	}
}
