using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.Upload)]
public class CustomFieldUpload : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField)
	/// </summary>
	private CustomFieldUpload()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldUpload(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.Upload;
	}
}
