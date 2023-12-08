using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping;
public class MapTranslation : IEntityTypeConfiguration<Translation>
{
	public void Configure(EntityTypeBuilder<Translation> builder)
	{
		builder.HasKey(e => e.Id);
		builder.Property(e => e.Id).ValueGeneratedNever();
		builder.HasAlternateKey(e => new { e.ObjectType, e.ObjectId, e.Language });

		builder.HasIndex(e => new { e.ObjectType, e.ObjectId, e.Language });
		builder.HasIndex(e => new { e.ObjectType, e.ObjectId });
		builder.HasIndex(e => new { e.ObjectId });

		builder.Property(e => e.Text)
			.HasMaxLength(4000)
			.IsUnicode()
			.IsConcurrencyToken();

		builder.Property(e => e.Language)
			.HasConversion<string>()
			.HasMaxLength(10);

		builder.Property(e => e.ObjectType)
			.HasConversion<string>()
			.HasMaxLength(100);
	}
}
