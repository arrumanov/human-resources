using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.Text)]
public class CustomFieldText : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField)
	/// </summary>
	public CustomFieldText()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldText(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.Text;
	}

	public CustomFieldText(string name, string fieldKey)
		: base(name, fieldKey)
	{
		Type = CustomFieldType.Text;
	}
}
