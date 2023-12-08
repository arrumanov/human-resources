using HR.CrossCutting.Enum;

namespace HR.Domain.Model;
public class Dictionary
{
	protected Dictionary()
	{

	}

	protected Dictionary(Guid id, string dictionaryKey, string name) : this()
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentException("Name is null or empty", nameof(name));
		}

		Id = id;
		DictionaryKey = dictionaryKey;
		Name = name;
	}

	public Dictionary(string dictionaryKey, string name) : this(Guid.NewGuid(), dictionaryKey, name)
	{
	}

	private string? _name;

	public Guid Id { get; set; }

	public string? Name
	{
		get => _name;
		set => _name = System.Text.RegularExpressions.Regex.Replace(value!.Trim(), @"\s+", " ");
	}
	public bool IsTranslatable { get; set; }
	public string DictionaryKey { get; protected set; } = default!;
	public bool IsBanOnRemoval { get; set; }
	public DictionaryCategory Category { get; set; }

	private readonly List<DictionaryValue> _dictionaryValues = new ();
	public IReadOnlyCollection<DictionaryValue> DictionaryValues => _dictionaryValues;


	public string GetLocalizedName(EnumLanguage language = EnumLanguage.Default)
	{
		var localized = Translations.FirstOrDefault(item => item.Language == language) ??
						Translations.FirstOrDefault(item => item.Language == EnumLanguage.Default);

		return localized == null ? Name??string.Empty : localized.Text??string.Empty;
	}

	public List<Translation> Translations { get; protected set; } = new List<Translation>();
}
