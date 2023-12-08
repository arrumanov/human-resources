using HR.CrossCutting.Attributes;
using HR.CrossCutting.Constants;
using HR.CrossCutting.Enum;
using HR.CrossCutting.Extentions;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.ComboBox)]
public class CustomFieldCombobox : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField) 
	/// </summary>
	public CustomFieldCombobox()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldCombobox(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.ComboBox;
	}

	public CustomFieldCombobox(string name, string fieldKey)
		: base(name, fieldKey)
	{
		Type = CustomFieldType.ComboBox;
	}

	public override bool IsValueRemovable(CustomFieldType customFieldType)
	{
		if (customFieldType == Type
			|| customFieldType == CustomFieldType.Multiselect
			|| customFieldType == CustomFieldType.Tags
			|| customFieldType == CustomFieldType.TagsWithLevel)
		{
			return false;
		}

		return true;
	}

	public override bool IsDeleteValueTranslation(CustomFieldType customFieldType)
	{
		if (customFieldType == CustomFieldType.Multiselect)
		{
			return false;
		}
		return true;
	}
	public override bool IsValueDictionaryRequired(CustomFieldType customFieldType)
	{
		if (customFieldType == CustomFieldType.Tags || customFieldType == CustomFieldType.TagsWithLevel)
		{
			return true;
		}
		return false;
	}
	public override List<CustomFieldValue> GetValuesForUpdate(CustomField entity, List<CustomFieldValue> customFieldValues,
		List<DictionaryValue> dictionaryValues)
	{
		var updateCustomFieldValues = new List<CustomFieldValue>();
		if (entity.Type != CustomFieldType.Multiselect)
		{
			string level = entity.DictionaryOfLevels?.DictionaryValues.OrderBy(item => item.Sequence).First().Id.ToFormatString()??string.Empty;
			foreach (var customFieldValue in customFieldValues)
			{
				if (string.IsNullOrWhiteSpace(customFieldValue.Text))
					continue;

				var newValues = dictionaryValues.First(item => item.Id.ToFormatString() == customFieldValue.Text).Text;
				if (entity.Type == CustomFieldType.TagsWithLevel)
				{
					newValues += string.Concat(UtilityConst.SplitterBetweenTagAndLevel, level);
				}
				customFieldValue.Text = newValues;
				updateCustomFieldValues.Add(customFieldValue);
			}
		}

		return updateCustomFieldValues;
	}
}
