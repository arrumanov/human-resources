using HR.CrossCutting.Enum;
using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace HR.Infrastructure.DataAccess.Mapping;
public class MapCustomFieldReference : IEntityTypeConfiguration<CustomFieldReference>
{
	public void Configure(EntityTypeBuilder<CustomFieldReference> builder)
	{
		builder.HasKey(e => e.Id);
		builder.Property(e => e.Id).ValueGeneratedNever();

		builder.HasAlternateKey(e => new { e.ObjectType, e.FieldKey });

		builder.HasOne(e => e.CustomField)
			.WithMany(e => e.CustomFieldReferences)
			.HasForeignKey(e => e.FieldKey)
			.HasPrincipalKey(e => e.FieldKey)
			.OnDelete(DeleteBehavior.ClientSetNull);

		builder.Property(e => e.NumericStep)
			.HasPrecision(18, 2);

		builder.Property(e => e.ObjectType)
			.HasConversion<string>()
			.HasMaxLength(100);

		builder.Property(e => e.TabType)
			.HasConversion<string>()
			.HasMaxLength(100);

		//Если мапить пропертю на более сложный объект, могут возникнуть проблемы при обновлении/сохранении (нужно настраивать comparer)
		//https://docs.microsoft.com/en-us/ef/core/modeling/value-comparers
		builder.Property(e => e.EventHandlers)
			.HasConversion(
				v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
				v => JsonSerializer.Deserialize<Dictionary<string, string>>(v, (JsonSerializerOptions)null));

		//Если мапить пропертю на более сложный объект, могут возникнуть проблемы при обновлении/сохранении (нужно настраивать comparer)
		//https://docs.microsoft.com/en-us/ef/core/modeling/value-comparers
		builder.Property(e => e.Props)
			.HasConversion(
				v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
				v => JsonSerializer.Deserialize<Dictionary<string, string>>(v, (JsonSerializerOptions)null));

		builder.Property(e => e.AccessBySystemRoleTypes)
			.HasConversion(
				srts => string.Join(", ", srts != null ? srts.ToArray() : new SystemRoleType[] { }),
				srts => srts.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList()
					.ConvertAll(item => (SystemRoleType)Enum.Parse(typeof(SystemRoleType), item, true)));

		builder.HasMany(e => e.Translations)
			.WithOne()
			.HasForeignKey(e => e.ObjectId)
			.HasPrincipalKey(e => e.Id)
			.OnDelete(DeleteBehavior.Cascade);
	}
}
