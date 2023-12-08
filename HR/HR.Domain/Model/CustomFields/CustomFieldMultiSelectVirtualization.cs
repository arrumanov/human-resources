using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.MultiselectVirtualization)]
public class CustomFieldMultiSelectVirtualization : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField)
	/// </summary>
	private CustomFieldMultiSelectVirtualization()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldMultiSelectVirtualization(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.MultiselectVirtualization;
	}
}
