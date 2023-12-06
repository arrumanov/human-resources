using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping
{
	public class MapUser : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			//entity.ToTable("Project");
			builder.HasKey(e => e.Id);
			builder.Property(e => e.Id).ValueGeneratedNever();

			builder.HasMany(e => e.UserJoinRole)
				.WithOne()
				.HasForeignKey(e => e.UserId)
				.OnDelete(DeleteBehavior.ClientSetNull);

			builder.HasMany(e => e.UserLanguages)
				.WithOne()
				.HasForeignKey(e => e.UserId)
				.OnDelete(DeleteBehavior.ClientSetNull);

			//builder.HasMany(e => e.Resources)
			//	.WithOne()
			//	.HasForeignKey(e => e.UserId)
			//	.OnDelete(DeleteBehavior.ClientSetNull);

			builder.Property(e => e.DefaultEnumLanguage)
				.HasConversion<string>()
				.HasMaxLength(10);
		}
	}
}
