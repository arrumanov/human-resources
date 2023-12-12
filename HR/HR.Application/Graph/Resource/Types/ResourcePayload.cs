namespace HR.Application.Graph.Resource.Types;
public class ResourcePayload
{
	public Guid Id { get; set; }
	public string Name { get; set; } = default!;
	public string Email { get; set; } = default!;
}
