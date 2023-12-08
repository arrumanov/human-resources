using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFieldValues;
public class CustomFieldValueNumeric : CustomFieldValue
{
	public CustomFieldValueNumeric(string fieldKey, Guid objectId)
		: base(Guid.NewGuid(), fieldKey, objectId)
	{

	}

	public override void SetValue(List<CustomFieldValueItem> value)
	{
		if (decimal.TryParse(value?.FirstOrDefault()?.Value, out decimal dValue))
		{
			Numeric = dValue;
		}
	}
}
