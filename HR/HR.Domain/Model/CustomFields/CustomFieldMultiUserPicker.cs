using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.MultiuserPicker)]
public class CustomFieldMultiUserPicker : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField)
	/// </summary>
	private CustomFieldMultiUserPicker()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldMultiUserPicker(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.MultiuserPicker;
	}
}
