namespace HR.Infrastructure.SearchEngine.Models;
public class BuildIndexRequest(string keyIndex)
{
	public string KeyIndex { get; set; } = keyIndex;
	public List<IndexObject> IndexObjects { get; set; } = [];
}

public class IndexObject
{
	public IndexObject()
	{

		KeyValues = new List<KeyValue>();
	}
	public string Id { get; set; } = default!;
	public List<KeyValue> KeyValues { get; set; }
}

public class KeyValue(string key, string value, KeyValueType type)
{
	public string Key { get; set; } = key;
	public string Value { get; set; } = value;
	public KeyValueType Type { get; } = type;
}

public enum KeyValueType
{
	String,
	Text,
	Guid,
	Other,
	Date,
	Int
}
