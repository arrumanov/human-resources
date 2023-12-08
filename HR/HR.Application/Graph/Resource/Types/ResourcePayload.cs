namespace HR.Application.Graph.Resource.Types;
public class ResourcesPayload
{
	public List<Resource> List { get; set; } = [];

	public int Count { get; set; }
}

public class Resource
{
	public Guid Id { get; set; }
	public string Name { get; set; } = default!;
	public string Email { get; set; } = default!;
}
