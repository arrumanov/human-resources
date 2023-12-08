using HR.Domain.Model;
using HR.Domain.Model.CustomFieldValues;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping;
public class MapCustomFieldValue : IEntityTypeConfiguration<CustomFieldValue>
{
	public void Configure(EntityTypeBuilder<CustomFieldValue> builder)
	{
		builder.HasKey(e => e.Id);
		builder.HasAlternateKey(e => new { e.FieldKey, e.ObjectId });
		builder.Property(e => e.Id).ValueGeneratedNever();

		builder.Property(e => e.Numeric)
			.HasPrecision(18, 2);

		//Для наследования TPH
		builder.HasDiscriminator()
			.HasValue<CustomFieldValueBool>(nameof(CustomFieldValueBool))
			.HasValue<CustomFieldValueDate>(nameof(CustomFieldValueDate))
			.HasValue<CustomFieldValueNumeric>(nameof(CustomFieldValueNumeric))
			.HasValue<CustomFieldValueText>(nameof(CustomFieldValueText));

		builder.HasMany(e => e.CustomFieldValueLanguages)
			.WithOne()
			.HasForeignKey(e => e.CustomFieldValueId)
			.OnDelete(DeleteBehavior.Cascade);

		builder.HasOne(e => e.CustomField)
			.WithMany()
			.HasForeignKey(e => e.FieldKey)
			.HasPrincipalKey(e => e.FieldKey)
			.OnDelete(DeleteBehavior.Cascade);

		//builder.HasMany(e => e.Translations)
		//    .WithOne()
		//    .HasForeignKey(e => e.ObjectId)
		//    .HasPrincipalKey(e => e.Id)
		//    //Удаление нужно производить вручную, иначе EF видит циклические каскадные удаления
		//    .OnDelete(DeleteBehavior.ClientSetNull);
	}
}
