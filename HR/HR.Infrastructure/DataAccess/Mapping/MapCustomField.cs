using HR.Domain.Model;
using HR.Domain.Model.CustomFields;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infrastructure.DataAccess.Mapping;
public class MapCustomField : IEntityTypeConfiguration<CustomField>
{
	public void Configure(EntityTypeBuilder<CustomField> builder)
	{
		builder.HasKey(e => e.Id);
		builder.Property(e => e.Id).ValueGeneratedNever();
		builder.HasAlternateKey(e => e.FieldKey);

		builder.Property(e => e.Category)
			.HasConversion<string>()
			.HasMaxLength(100);

		//Для наследования TPH
		builder.HasDiscriminator()
			.HasValue<CustomFieldBool>(nameof(CustomFieldBool))
			.HasValue<CustomFieldColor>(nameof(CustomFieldColor))
			.HasValue<CustomFieldCombobox>(nameof(CustomFieldCombobox))
			.HasValue<CustomFieldComboBoxVirtualization>(nameof(CustomFieldComboBoxVirtualization))
			.HasValue<CustomFieldDate>(nameof(CustomFieldDate))
			.HasValue<CustomFieldDecimal>(nameof(CustomFieldDecimal))
			.HasValue<CustomFieldDecimal>(nameof(CustomFieldDecimal))
			.HasValue<CustomFieldEnumComboBox>(nameof(CustomFieldEnumComboBox))
			.HasValue<CustomFieldDecimalWithPostfix>(nameof(CustomFieldDecimalWithPostfix))
			.HasValue<CustomFieldInt>(nameof(CustomFieldInt))
			.HasValue<CustomFieldMultiSelect>(nameof(CustomFieldMultiSelect))
			.HasValue<CustomFieldMultiSelectVirtualization>(nameof(CustomFieldMultiSelectVirtualization))
			.HasValue<CustomFieldMultiUserPicker>(nameof(CustomFieldMultiUserPicker))
			.HasValue<CustomFieldTags>(nameof(CustomFieldTags))
			.HasValue<CustomFieldTagsWithLevel>(nameof(CustomFieldTagsWithLevel))
			.HasValue<CustomFieldText>(nameof(CustomFieldText))
			.HasValue<CustomFieldTextArea>(nameof(CustomFieldTextArea))
			.HasValue<CustomFieldTextAreaSimple>(nameof(CustomFieldTextAreaSimple))
			.HasValue<CustomFieldUpload>(nameof(CustomFieldUpload))
			.HasValue<CustomFieldRangeInt>(nameof(CustomFieldRangeInt))
			.HasValue<CustomFieldCheckbox>(nameof(CustomFieldCheckbox));


		builder.HasOne(e => e.Dictionary)
			.WithMany()
			.HasForeignKey(e => e.DictionaryKey)
			.HasPrincipalKey(e => e.DictionaryKey)
			.OnDelete(DeleteBehavior.ClientSetNull);

		builder.HasOne(e => e.DictionaryOfLevels)
			.WithMany()
			.HasForeignKey(e => e.DictionaryOfLevelsKey)
			.HasPrincipalKey(e => e.DictionaryKey)
			.OnDelete(DeleteBehavior.ClientSetNull);

		builder.Property(e => e.Type)
			.HasConversion<string>()
			.HasMaxLength(100);

		builder.HasMany(e => e.Translations)
			.WithOne()
			.HasForeignKey(e => e.ObjectId)
			.HasPrincipalKey(e => e.Id)
			.OnDelete(DeleteBehavior.NoAction);

	}
}
