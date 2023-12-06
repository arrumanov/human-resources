namespace HR.Domain.Model
{
	public class UserJoinRole
	{
		public UserJoinRole()
		{

		}
		public Guid UserId { get; set; }
		public Guid RoleId { get; set; }

		public Role Role { get; set; } = new Role();
	}
}
