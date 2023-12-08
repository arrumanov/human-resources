using HR.Domain.Model;

namespace HR.Domain.Utils.CustomFieldUtil;
public class FillDefault : IFillCustomFieldProps
{
	public void FillCustomFieldProps(CustomField customField, CustomFieldDto customFieldDto)
	{
		customField.Id = (customFieldDto.Id != Guid.Empty) ? customFieldDto.Id : Guid.NewGuid();
		customField.Name = customFieldDto.FieldName;
		customField.Type = customFieldDto.FieldType;
		customField.DictionaryKey = customFieldDto.DictionaryKey;
		customField.DictionaryOfLevelsKey = customFieldDto.DictionaryOfLevelsKey;
		customField.IsBanOnRemoval = customFieldDto.IsBanOnRemoval;
		customField.Category = customFieldDto.Category;
		customField.Description = customFieldDto.Description;
	}
}
