using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping;
public class MapColor : IEntityTypeConfiguration<Color>
{
	public void Configure(EntityTypeBuilder<Color> builder)
	{
		builder.HasKey(e => e.Id);
		builder.Property(e => e.Id).ValueGeneratedNever();
	}
}
