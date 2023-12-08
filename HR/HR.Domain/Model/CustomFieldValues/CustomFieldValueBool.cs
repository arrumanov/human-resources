using HR.Domain.Utils.CustomFieldUtil;
namespace HR.Domain.Model.CustomFieldValues;
public class CustomFieldValueBool : CustomFieldValue
{
	public CustomFieldValueBool(string fieldKey, Guid objectId)
		: base(Guid.NewGuid(), fieldKey, objectId)
	{

	}

	public override void SetValue(List<CustomFieldValueItem> value)
	{
		if (bool.TryParse(value?.FirstOrDefault()?.Value, out var bValue))
		{
			Bool = bValue;
		}
	}
}
