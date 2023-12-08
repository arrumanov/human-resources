namespace HR.Domain.Model;
public class DictionaryValueMapping
{
	public Guid Id { get; set; }
	public string DictionaryKey { get; set; } = default!;
	public Guid DictionaryValueId { get; set; }
	public List<Guid> MappingValues { get; set; } = new ();

	public Dictionary Dictionary { get; set; } = default!;
	public DictionaryValue DictionaryValue { get; set; } = default!;

	protected DictionaryValueMapping()
	{

	}

	protected DictionaryValueMapping(Guid id, string dictionaryKey, Guid dictionaryValueId, List<Guid> mappingValues)
		: this()
	{
		Id = id;
		DictionaryKey = dictionaryKey;
		DictionaryValueId = dictionaryValueId;
		MappingValues = mappingValues;
	}

	public DictionaryValueMapping(string dictionaryKey, Guid dictionaryValueId, List<Guid> mappingValues)
		: this(Guid.NewGuid(), dictionaryKey, dictionaryValueId, mappingValues)
	{
	}
}
