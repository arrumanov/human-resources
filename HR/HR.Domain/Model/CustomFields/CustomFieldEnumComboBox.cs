using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.EnumComboBox)]
public class CustomFieldEnumComboBox : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField) 
	/// </summary>
	public CustomFieldEnumComboBox()
	{
		FillBehaviour = new FillDefault();
	}

	public CustomFieldEnumComboBox(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.EnumComboBox;
	}
}
