namespace HR.Domain.Model;
public class ResourceUniqKey
{
	public Guid ResourceId { get; set; }
	public string ExternalKey { get; set; } = default!;
	public string SystemKey { get; set; } = default!;

	public ResourceUniqKey()
	{

	}

	public ResourceUniqKey(Guid resourceId, string externalKey, string systemKey)
	{
		ExternalKey = externalKey;
		SystemKey = systemKey;
		ResourceId = resourceId;
	}
}
