namespace HR.Application.Graph.Resource.Types;
public class ResourcesPayload
{
	public List<ResourcePayload> List { get; set; } = [];

	public int Count { get; set; }
}
