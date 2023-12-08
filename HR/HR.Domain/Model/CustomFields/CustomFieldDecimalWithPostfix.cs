using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.DecimalWithPostfix)]
public class CustomFieldDecimalWithPostfix : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField)
	/// </summary>
	private CustomFieldDecimalWithPostfix()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldDecimalWithPostfix(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.DecimalWithPostfix;
	}
}
