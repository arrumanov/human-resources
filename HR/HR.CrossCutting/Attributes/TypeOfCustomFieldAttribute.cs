using HR.CrossCutting.Enum;

namespace HR.CrossCutting.Attributes;
public class TypeOfCustomFieldAttribute : Attribute
{
	public CustomFieldType CustomFieldEnumType { get; set; }
}
