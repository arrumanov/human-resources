using HR.CrossCutting.Attributes;
using HR.CrossCutting.Constants;
using HR.CrossCutting.Enum;
using HR.CrossCutting.Extentions;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.Multiselect)]
public class CustomFieldMultiSelect : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField) 
	/// </summary>
	public CustomFieldMultiSelect()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldMultiSelect(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.Multiselect;
	}
	public override bool IsValueRemovable(CustomFieldType customFieldType)
	{
		if (customFieldType == Type
			|| customFieldType == CustomFieldType.Tags
			|| customFieldType == CustomFieldType.TagsWithLevel)
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
		string level = entity.DictionaryOfLevels?.DictionaryValues.OrderBy(item => item.Sequence).First().Id.ToFormatString()??string.Empty;
		foreach (var customFieldValue in customFieldValues)
		{
			if (string.IsNullOrWhiteSpace(customFieldValue.Text))
				continue;

			var newValues = new List<string>();
			foreach (var value in customFieldValue.GetValues(CustomFieldType.Multiselect))
			{
				var newValue = dictionaryValues.First(item => item.Id.ToFormatString() == value).Text;
				if (entity.Type == CustomFieldType.TagsWithLevel)
				{
					newValue += string.Concat(UtilityConst.SplitterBetweenTagAndLevel, level);
				}
				if (newValue != null)
				{
					newValues.Add(newValue);
				}
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
