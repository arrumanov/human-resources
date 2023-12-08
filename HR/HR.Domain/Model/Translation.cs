using HR.CrossCutting.Enum;

namespace HR.Domain.Model;
public class Translation
{
	private string? _text;

	public string? Text
	{
		get => _text;
		set
		{
			_text = value!.Trim();
			if (_text.Length > 4000)
			{
				_text = _text.Substring(0, 3997) + "...";
			}
		}
	}

	public Guid Id { get; set; }
	public Guid ObjectId { get; set; }
	public EnumLanguage Language { get; set; }
	public ObjectType ObjectType { get; set; }

	protected Translation()
	{
	}

	protected Translation(Guid id, string text, Guid objectId, EnumLanguage language, ObjectType objectType)
		: this()
	{
		Id = id;
		Text = text;
		ObjectId = objectId;
		Language = language;
		ObjectType = objectType;
	}

	public Translation(string text, Guid objectId, EnumLanguage language, ObjectType objectType)
		: this(Guid.NewGuid(), text, objectId, language, objectType)
	{
	}
}
