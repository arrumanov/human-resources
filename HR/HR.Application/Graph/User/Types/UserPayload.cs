namespace HR.Application.Graph.User.Types;
public class UserPayload
{
	public Guid Id { get; set; }
	public string Login { get; set; } = default!;
	public string Email { get; set; } = default!;
	public string Name { get; set; } = default!;
}
