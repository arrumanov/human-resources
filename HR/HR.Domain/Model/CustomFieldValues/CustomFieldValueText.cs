using HR.CrossCutting.Constants;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model.CustomFieldValues;
public class CustomFieldValueText : CustomFieldValue
{
	public CustomFieldValueText(string fieldKey, Guid objectId)
		: base(Guid.NewGuid(), fieldKey, objectId)
	{

	}

	public override void SetValue(List<CustomFieldValueItem> value)
	{
		//если приходит пустой объект, значит мы хотим удалить все данные
		if (value == null || value.All(item => string.IsNullOrWhiteSpace(item.Value)))
		{
			Text = null;
		}
		//если приходит хотя бы один элемент и при этом любой Level == string.IsNullOrWhiteSpace, значит пришёл один элемент
		//и это не метка с уровнем, поэтому записываем просто как текст (без сплиттеров)
		else if (value.Count == 1 && string.IsNullOrWhiteSpace(value.First().Level))
		{
			Text = value.FirstOrDefault()?.Value;
		}
		//если приходит больше одного элемента и при этом любой Level == string.IsNullOrWhiteSpace, значит пришёл множественный выбор 
		//и это не метка с уровнем, поэтому записываем через сплиттер
		else if (value.Count > 1 && string.IsNullOrWhiteSpace(value.First().Level))
		{
			Text = string.Join(UtilityConst.Splitter, value.Where(item => !string.IsNullOrWhiteSpace(item.Value)).Select(item => item.Value));
		}
		//если приходит больше одного элемента и при этом любой Level != IsNullOrWhiteSpace, значит пришли метки с уровнем (TagsWithLevel) 
		else
		{
			var twlValues = value.Where(item => !string.IsNullOrWhiteSpace(item.Value))
				.Select(item => $"{item.Value}{UtilityConst.SplitterBetweenTagAndLevel}{item.Level}").ToList();
			Text = twlValues.Count == 0 ? null : string.Join(UtilityConst.Splitter, twlValues);
		}
	}
}
