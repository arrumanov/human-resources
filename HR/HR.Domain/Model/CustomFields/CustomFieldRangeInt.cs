using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.RangeInt)]
public class CustomFieldRangeInt : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField)
	/// </summary>
	private CustomFieldRangeInt()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldRangeInt(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.Textarea;
	}
}
