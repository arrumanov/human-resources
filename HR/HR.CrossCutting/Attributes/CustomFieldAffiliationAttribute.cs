using HR.CrossCutting.Enum;

namespace HR.CrossCutting.Attributes;
public class CustomFieldAffiliationAttribute : Attribute
{
	public CustomFieldAffiliationAttribute(CustomFieldAffiliationType[] types)
	{
		CustomFieldAffiliationTypes = types;
	}

	public CustomFieldAffiliationType[] CustomFieldAffiliationTypes { get; set; }
}
