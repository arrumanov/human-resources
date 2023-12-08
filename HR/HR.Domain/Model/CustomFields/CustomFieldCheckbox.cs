using HR.CrossCutting.Attributes;
using HR.CrossCutting.Enum;

namespace HR.Domain.Model.CustomFields;

[TypeOfCustomField(CustomFieldEnumType = CustomFieldType.CheckBox)]
public class CustomFieldCheckbox : CustomField
{
}
