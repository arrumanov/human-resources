using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.Textarea)]
public class CustomFieldTextArea : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField)
	/// </summary>
	private CustomFieldTextArea()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldTextArea(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.Textarea;
	}

	public CustomFieldTextArea(string name, string fieldKey)
		: base(name, fieldKey)
	{
		Type = CustomFieldType.Textarea;
	}
}
