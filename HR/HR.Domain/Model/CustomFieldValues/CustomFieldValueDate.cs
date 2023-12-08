using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFieldValues;
public class CustomFieldValueDate : CustomFieldValue
{
	public CustomFieldValueDate(string fieldKey, Guid objectId)
		: base(Guid.NewGuid(), fieldKey, objectId)
	{

	}

	public override void SetValue(List<CustomFieldValueItem> value)
	{
		var strValue = value?.FirstOrDefault()?.Value;
		if (strValue != null)
		{
			if (System.DateTime.TryParse(strValue, out DateTime dtValue))
			{
				DateTime = dtValue;
			}
		}
		else
		{
			DateTime = null;
		}
	}
}
