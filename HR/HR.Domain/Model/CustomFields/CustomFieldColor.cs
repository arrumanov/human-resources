using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.Color)]
public class CustomFieldColor : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField)
	/// </summary>
	public CustomFieldColor()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldColor(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.Color;
	}
}
