using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.Decimal)]
public class CustomFieldDecimal : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField) 
	/// </summary>
	public CustomFieldDecimal()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldDecimal(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.Decimal;
	}
}
