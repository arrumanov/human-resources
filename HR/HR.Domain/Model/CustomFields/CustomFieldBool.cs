using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.Bool)]
public class CustomFieldBool : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField)
	/// </summary>
	private CustomFieldBool()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldBool(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.Bool;
	}
}
