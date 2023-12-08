using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping;
public class MapDictionaryValueUniqKey : IEntityTypeConfiguration<DictionaryValueUniqKey>
{
	public void Configure(EntityTypeBuilder<DictionaryValueUniqKey> builder)
	{
		builder.HasKey(e => new { e.ExternalKey, e.SystemKey });

		builder.HasOne(e => e.DictionaryValue)
			.WithMany()
			.HasForeignKey(item => item.DictionaryValueId)
			.OnDelete(DeleteBehavior.Cascade);
	}
}
