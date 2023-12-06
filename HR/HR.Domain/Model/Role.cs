using HR.CrossCutting.Enum;

namespace HR.Domain.Model
{
	public class Role
	{
		public Guid Id { get; set; }
		public SystemRoleType SystemRoleType { get; set; }
		public string Name { get; set; } = default!;
		public bool IsDeleteble { get; set; }
		public bool IsVisible { get; set; }

		public Role()
		{

		}

		protected Role(Guid id, SystemRoleType systemRoleType, string name, bool isDeleteble)
		{
			Id = id;
			SystemRoleType = systemRoleType;
			Name = name;
			IsDeleteble = isDeleteble;
		}

		public Role(SystemRoleType systemRoleType, string name, bool isDeleteble)
			: this(Guid.NewGuid(), systemRoleType, name, isDeleteble)
		{
		}
	}
}
