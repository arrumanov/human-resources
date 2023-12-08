using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping;
public class MapHeadOfDepartment : IEntityTypeConfiguration<HeadOfDepartment>
{
	public void Configure(EntityTypeBuilder<HeadOfDepartment> builder)
	{
		builder.HasKey(e => e.Id);
		builder.Property(e => e.Id).ValueGeneratedNever();
		builder.HasOne(e => e.HeadResource)
			.WithMany(e => e.HeadOfDepartments)
			.HasForeignKey(e => e.HeadOfDepartmentId)
			.OnDelete(DeleteBehavior.ClientSetNull);
		builder.HasOne(e => e.DeputyHeadResource)
			.WithMany(e => e.DeputyHeads)
			.HasForeignKey(e => e.DeputyId)
			.OnDelete(DeleteBehavior.ClientSetNull);
		builder.Property(e => e.DepartmentsId)
			.HasConversion(
				users => string.Join(", ", users != null ? users.ToArray() : new Guid[] { }),
				users => users.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList()
					.ConvertAll(Guid.Parse));

		builder.Property(e => e.Code)
			.HasMaxLength(100);
	}
}
