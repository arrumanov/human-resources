using HR.CrossCutting.Enum;

namespace HR.Domain.Model;
public class DictionaryValue
{
	private string? _text;
	public Guid Id { get; set; }
	public string DictionaryKey { get; set; } = default!;
	public DictionaryValueMapping? DictionaryValueMapping { get; set; }
	public string? Text
	{
		get => _text;
		set => _text = System.Text.RegularExpressions.Regex.Replace(value!.Trim(), @"\s+", " ");
	}
	public bool IsActive { get; set; }
	public string? HexColor { get; set; } = default!;
	public int Sequence { get; set; }
	public string? Code { get; set; }

	public List<Translation> Translations { get; protected set; } = new ();


	protected DictionaryValue()
	{

	}

	protected DictionaryValue(Guid id, string dictionaryKey, string text)
		: this()
	{
		if (string.IsNullOrWhiteSpace(text))
		{
			throw new ArgumentException("Value is null or empty", nameof(text));
		}

		Id = id;
		DictionaryKey = dictionaryKey;
		Text = text;
	}

	public DictionaryValue(string dictionaryKey, string text)
		: this(Guid.NewGuid(), dictionaryKey, text)
	{
		IsActive = true;
		HexColor = "#00000000";
	}

	public string GetLocalizedText(EnumLanguage language = EnumLanguage.Default)
	{
		var localized = Translations.FirstOrDefault(item => item.Language == language) ??
						Translations.FirstOrDefault(item => item.Language == EnumLanguage.Default);

		return localized == null ? Text??string.Empty : localized.Text??string.Empty;
	}
}
