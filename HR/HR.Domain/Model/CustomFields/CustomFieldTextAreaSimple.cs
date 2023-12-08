using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.TextareaSimple)]
public class CustomFieldTextAreaSimple : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField)
	/// </summary>
	private CustomFieldTextAreaSimple()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldTextAreaSimple(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.Textarea;
	}
}
