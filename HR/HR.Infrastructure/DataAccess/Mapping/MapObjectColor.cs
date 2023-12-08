using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping;
public class MapObjectColor : IEntityTypeConfiguration<ObjectColor>
{
	public void Configure(EntityTypeBuilder<ObjectColor> builder)
	{
		builder.HasKey(e => e.Id);
		builder.Property(e => e.Id).ValueGeneratedNever();
		builder.HasAlternateKey(e => new { e.ObjectId, e.UserId });

		builder.Property(e => e.ObjectType)
			.HasConversion<string>()
			.HasMaxLength(100);
	}
}
