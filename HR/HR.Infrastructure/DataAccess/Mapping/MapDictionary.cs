using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping;

using Dictionary = Domain.Model.Dictionary;
public class MapDictionary : IEntityTypeConfiguration<Dictionary>
{
	public void Configure(EntityTypeBuilder<Dictionary> builder)
	{
		builder.HasKey(e => e.Id);
		builder.Property(e => e.Id).ValueGeneratedNever();
		builder.HasAlternateKey(e => e.DictionaryKey);

		builder.Property(e => e.Category)
			.HasConversion<string>()
			.HasMaxLength(100);

		builder.HasMany(e => e.Translations)
			.WithOne()
			.HasForeignKey(e => e.ObjectId)
			.HasPrincipalKey(e => e.Id)
			.OnDelete(DeleteBehavior.Cascade);

		builder.HasMany(e => e.DictionaryValues)
			.WithOne()
			.HasForeignKey(e => e.DictionaryKey)
			.HasPrincipalKey(e => e.DictionaryKey)
			.OnDelete(DeleteBehavior.ClientSetNull);
	}
}
