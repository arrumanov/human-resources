using HR.CrossCutting.Attributes;
using HR.CrossCutting.Constants;
using HR.CrossCutting.Enum;
using HR.CrossCutting.Extentions;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.TagsWithLevel)]
public class CustomFieldTagsWithLevel : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField) 
	/// </summary>
	public CustomFieldTagsWithLevel()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldTagsWithLevel(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.TagsWithLevel;
	}
	public override bool IsValueRemovable(CustomFieldType customFieldType)
	{
		if (customFieldType == Type
			|| customFieldType == CustomFieldType.Multiselect
			|| customFieldType == CustomFieldType.Tags)
		{
			return false;
		}

		return true;
	}
	public override bool IsValueDictionaryRequired(CustomFieldType customFieldType)
	{
		if (customFieldType == CustomFieldType.Multiselect)
		{
			return true;
		}
		return false;
	}
	public override List<CustomFieldValue> GetValuesForUpdate(CustomField entity, List<CustomFieldValue> customFieldValues,
		List<DictionaryValue> dictionaryValues)
	{
		var updateCustomFieldValues = new List<CustomFieldValue>();
		foreach (var customFieldValue in customFieldValues)
		{
			if (string.IsNullOrWhiteSpace(customFieldValue.Text))
				continue;

			var newValues = new List<string>();
			if (entity.Type == CustomFieldType.Tags)
			{
				newValues = customFieldValue.GetValues(CustomFieldType.TagsWithLevel);
			}
			else if (entity.Type == CustomFieldType.Multiselect)
			{
				newValues = customFieldValue.GetValues(CustomFieldType.TagsWithLevel)
					.Select(item => dictionaryValues.First(el => el.Text == item).Id.ToFormatString()).ToList();
			}

			if (newValues.Count > 0)
			{
				customFieldValue.Text = string.Join(UtilityConst.Splitter, newValues);
				updateCustomFieldValues.Add(customFieldValue);
			}
		}
		return updateCustomFieldValues;
	}
}
