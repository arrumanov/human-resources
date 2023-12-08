using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping;
public class MapFavorite : IEntityTypeConfiguration<Favorite>
{
	public void Configure(EntityTypeBuilder<Favorite> builder)
	{
		builder.HasKey(e => e.Id);
		builder.Property(e => e.Id).ValueGeneratedNever();

		builder.HasAlternateKey(e => new { e.FavoriteType, e.ObjectId, e.UserId });
	}
}
