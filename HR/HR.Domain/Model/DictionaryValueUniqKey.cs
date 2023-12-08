namespace HR.Domain.Model;
public class DictionaryValueUniqKey
{
	public Guid DictionaryValueId { get; set; }
	public string ExternalKey { get; set; } = default!;
	public string SystemKey { get; set; } = default!;

	public DictionaryValue DictionaryValue { get; set; } = default!;

	protected DictionaryValueUniqKey()
	{
	}

	public DictionaryValueUniqKey(Guid dictionaryValueId, string externalKey, string systemKey) : this()
	{
		DictionaryValueId = dictionaryValueId;
		ExternalKey = externalKey;
		SystemKey = systemKey;
	}
}
