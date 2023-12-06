using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping
{
	public class MapUserLanguage : IEntityTypeConfiguration<UserLanguage>
	{
		public void Configure(EntityTypeBuilder<UserLanguage> builder)
		{
			builder.HasKey(e => e.Id);
			builder.Property(e => e.Id).ValueGeneratedNever();
		}
	}
}
