using HR.CrossCutting.Constants;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model;
public class CustomFieldValue
{
	public Guid Id { get; set; }
	public Guid ObjectId { get; set; }
	public decimal? Numeric { get; set; }
	public string? Text { get; set; }
	public DateTime? DateTime { get; set; }
	public bool? Bool { get; set; }
	public string FieldKey { get; set; } = default!;

	#region Navigation properties

	private readonly List<CustomFieldValueLanguage> _сustomFieldValueLanguages = new ();
	public IReadOnlyCollection<CustomFieldValueLanguage> CustomFieldValueLanguages => _сustomFieldValueLanguages;
	public CustomField CustomField { get; set; } = default!;

	#endregion

	protected CustomFieldValue()
	{
		_сustomFieldValueLanguages = new List<CustomFieldValueLanguage>();
	}


	public CustomFieldValue(Guid id, string fieldKey, Guid objectId) : this()
	{
		Id = id;
		FieldKey = fieldKey;
		ObjectId = objectId;
	}

	public CustomFieldValue(string fieldKey, Guid objectId) : this(Guid.NewGuid(),
		fieldKey, objectId)
	{
	}


	public void SetValue(string value, CustomField customField)
	{
		switch (customField.Type)
		{
			case CustomFieldType.Text:
			case CustomFieldType.DecimalWithPostfix:
			case CustomFieldType.ComboBox:
			case CustomFieldType.ComboBoxVirtualization:
			case CustomFieldType.EnumComboBox:
			case CustomFieldType.Textarea:
			case CustomFieldType.TextareaSimple:
				Text = value;
				break;
			case CustomFieldType.CheckBox:
			case CustomFieldType.Bool:
				if (bool.TryParse(value, out bool bValue))
				{
					Bool = bValue;
				}

				break;
			case CustomFieldType.Int:
			case CustomFieldType.Decimal:
				if (decimal.TryParse(value, out decimal dValue))
				{
					Numeric = dValue;
				}

				break;
			case CustomFieldType.Date:
				if (value != null)
				{
					if (System.DateTime.TryParse(value, out DateTime dtValue))
					{
						DateTime = dtValue;
					}
				}
				else
				{
					DateTime = null;
				}

				break;
			case CustomFieldType.Color:
				break;
			case CustomFieldType.Multiselect:
			case CustomFieldType.MultiselectVirtualization:
			case CustomFieldType.Tags:
			case CustomFieldType.TagsWithLevel:
			case CustomFieldType.MultiuserPicker:
				if (value == null)
				{
					Text = null;
					break;
				}
				Text = value;
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}
	}

	public void SetValue(List<CustomFieldValueItem> value, CustomFieldType customFieldType)
	{
		switch (customFieldType)
		{
			case CustomFieldType.Text:
			case CustomFieldType.DecimalWithPostfix:
			case CustomFieldType.ComboBox:
			case CustomFieldType.ComboBoxVirtualization:
			case CustomFieldType.EnumComboBox:
				Text = value?.FirstOrDefault()?.Value;
				break;

			case CustomFieldType.Bool:
				if (bool.TryParse(value?.FirstOrDefault()?.Value, out var bValue))
				{
					Bool = bValue;
				}
				break;
			case CustomFieldType.Int:
			case CustomFieldType.Decimal:
				if (decimal.TryParse(value?.FirstOrDefault()?.Value, out decimal dValue))
				{
					Numeric = dValue;
				}
				break;
			case CustomFieldType.Date:
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

				break;
			case CustomFieldType.Color:
				break;
			case CustomFieldType.Multiselect:
			case CustomFieldType.MultiselectVirtualization:
			case CustomFieldType.Tags:
			case CustomFieldType.MultiuserPicker:
				if (value == null || value.Count == 0)
				{
					Text = null;
				}
				else
				{
					Text = string.Join(UtilityConst.Splitter, value.Select(item => item.Value));
				}
				break;
			case CustomFieldType.TagsWithLevel:
				var twlValues = value?
					.Select(item => $"{item.Value}{UtilityConst.SplitterBetweenTagAndLevel}{item.Level}").ToList();
				if (twlValues == null || twlValues.Count == 0)
				{
					Text = null;
				}
				else
				{
					Text = string.Join(UtilityConst.Splitter, twlValues);
				}
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}
	}

	public List<string> GetViewValue(CustomField customField)
	{
		return customField.Type switch
		{
			CustomFieldType.TagsWithLevel
				=> Text == null ? new List<string> { } : [.. Text.Split(UtilityConst.Splitter)],
			_ => GetValues(customField.Type)
		};
	}

	public List<string> GetValues(CustomFieldType type) => type switch
	{
		CustomFieldType.Text or
			CustomFieldType.Textarea or
			CustomFieldType.TextareaSimple or
			CustomFieldType.DecimalWithPostfix or
			CustomFieldType.ComboBox or
			CustomFieldType.ComboBoxVirtualization or
			CustomFieldType.EnumComboBox
			=> [Text!],
		CustomFieldType.Bool or
			CustomFieldType.CheckBox
			=> [Bool.ToString()!],
		CustomFieldType.Int or
			CustomFieldType.Decimal
			=> [Numeric.ToString()!],
		CustomFieldType.Date
			=> DateTime.HasValue ? new List<string> { DateTime.Value.ToString() } : new List<string>(),
		CustomFieldType.Color => new List<string>(),
		CustomFieldType.Multiselect or
			CustomFieldType.MultiselectVirtualization or
			CustomFieldType.Tags or
			CustomFieldType.MultiuserPicker
			=> Text == null ? new List<string> { } : Text.Split(UtilityConst.Splitter).ToList(),
		CustomFieldType.TagsWithLevel
			=> Text == null ? new List<string> { } : Text.Split(UtilityConst.Splitter)
				.Select(item => item.Split(UtilityConst.SplitterBetweenTagAndLevel).First()).ToList(),
		_ => throw new ArgumentOutOfRangeException()
	};

	public virtual void SetValue(List<CustomFieldValueItem> value)
	{
		throw new Exception("Тип CustomFieldValue не задан!");
	}
}
