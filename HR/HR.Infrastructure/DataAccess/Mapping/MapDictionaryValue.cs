using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping;
public class MapDictionaryValue : IEntityTypeConfiguration<DictionaryValue>
{
	public void Configure(EntityTypeBuilder<DictionaryValue> builder)
	{
		builder.HasKey(e => e.Id);
		builder.Property(e => e.Id).ValueGeneratedNever();

		builder.HasMany(e => e.Translations)
			.WithOne()
			.HasForeignKey(e => e.ObjectId)
			.HasPrincipalKey(e => e.Id)
			.OnDelete(DeleteBehavior.Cascade);

		builder.HasAlternateKey(e => new { e.Id, e.DictionaryKey });

		builder.Property(e => e.HexColor)
			.HasMaxLength(100);

		builder.Property(e => e.Code)
			.HasMaxLength(100);
	}
}
