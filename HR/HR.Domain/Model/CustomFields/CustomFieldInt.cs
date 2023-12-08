using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.Int)]
public class CustomFieldInt : CustomField
{
	/// <summary>
	/// Используется для создания объекта через рефлексию (метод CreateConcreteCustomField) 
	/// </summary>
	public CustomFieldInt()
	{
		FillBehaviour = new FillDefault();
	}
	public CustomFieldInt(string name)
		: base(Guid.NewGuid(), name)
	{
		Type = CustomFieldType.Int;
	}
	public override bool IsValueRemovable(CustomFieldType customFieldType)
	{
		if (customFieldType == Type
			|| customFieldType == CustomFieldType.Decimal)
		{
			return false;
		}

		return true;
	}
}
