using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping;
public class MapResourceUniqKey : IEntityTypeConfiguration<ResourceUniqKey>
{
	public void Configure(EntityTypeBuilder<ResourceUniqKey> builder)
	{
		builder.HasKey(e => new { e.ResourceId, e.ExternalKey, e.SystemKey });

	}
}
