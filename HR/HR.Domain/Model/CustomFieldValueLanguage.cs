using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model;
public class CustomFieldValueLanguage
{
	public Guid Id { get; set; }
	public Guid CustomFieldValueId { get; set; }
	public string? Text { get; set; }
	public EnumLanguage Language { get; set; }


	protected CustomFieldValueLanguage()
	{
	}


	protected CustomFieldValueLanguage(Guid id, Guid customFieldValueId, string text, EnumLanguage language)
		: this()
	{
		Id = id;
		CustomFieldValueId = customFieldValueId;
		Text = text;
		Language = language;
	}

	public CustomFieldValueLanguage(Guid customFieldValueId, string text, EnumLanguage language)
		: this(Guid.NewGuid(), customFieldValueId, text, language)
	{
	}

	public void SetValue(string value, CustomField customField)
	{
		Text = customField.Type switch
		{
			CustomFieldType.Text or CustomFieldType.Textarea or CustomFieldType.TextareaSimple => value,
			_ => null
		};
	}

	public void SetValue(List<CustomFieldValueItem> value, CustomFieldType customFieldType)
	{
		Text = customFieldType switch
		{
			CustomFieldType.Text or CustomFieldType.Textarea or CustomFieldType.TextareaSimple => value?.FirstOrDefault()?.Value,
			_ => null
		};
	}
}
