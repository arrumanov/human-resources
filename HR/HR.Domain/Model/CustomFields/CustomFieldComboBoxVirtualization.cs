using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.ComboBoxVirtualization)]
public class CustomFieldComboBoxVirtualization : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField)
	/// </summary>
	private CustomFieldComboBoxVirtualization()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldComboBoxVirtualization(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.ComboBoxVirtualization;
	}
}
