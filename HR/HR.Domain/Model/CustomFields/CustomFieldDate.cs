using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.Date)]
public class CustomFieldDate : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField)
	/// </summary>
	private CustomFieldDate()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldDate(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.Date;
	}
}
