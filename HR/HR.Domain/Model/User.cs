using HR.CrossCutting.Enum;
using System.Data;

namespace HR.Domain.Model
{
	public class User
	{
		protected User()
		{
			UserJoinRole = new List<UserJoinRole>();
			UserLanguages = new List<UserLanguage>();
			//Resources = new List<Resource>();
		}


		protected User(Guid id, string login, EnumLanguage defaultEnumLanguage)
			: this()
		{
			if (string.IsNullOrWhiteSpace(login))
			{
				throw new ArgumentException("Login is null or empty", nameof(login));
			}

			Id = id;
			DefaultEnumLanguage = defaultEnumLanguage;
			Login = login;
			LoginType = LoginType.Never;
		}

		public User(string login, EnumLanguage defaultEnumLanguage)
			: this(Guid.NewGuid(), login, defaultEnumLanguage)
		{
		}

		public Guid Id { get; set; }
		public EnumLanguage DefaultEnumLanguage { get; set; }
		public string Login { get; set; } = default!;
		public string Email { get; set; } = default!;
		public string Name { get; set; } = default!;
		public LoginType LoginType { get; set; }
		public Guid? LatestUsedVersionId { get; set; }


		public ICollection<UserLanguage> UserLanguages { get; private set; }
		public ICollection<UserJoinRole> UserJoinRole { get; private set; }
		//public ICollection<Resource> Resources { get; private set; }


		public string GetUserSmallName(EnumLanguage? enumLanguage = null)
		{
			if (!enumLanguage.HasValue)
			{
				return Name;
			}
			var l = UserLanguages.FirstOrDefault(item => item.EnumLanguage == enumLanguage);
			return l == null ? Name : l.SmallName;
		}

		public void AddRole(Role role)
		{
			if (UserJoinRole == null)
			{
				UserJoinRole = new List<UserJoinRole>();
			}
			else
			{
				if (UserJoinRole.Any(item => item.RoleId == role.Id))
				{
					return;
				}
			}

			UserJoinRole.Add(new UserJoinRole
			{
				RoleId = role.Id,
				UserId = Id
			});
		}

		public void DeleteRole(Role role)
		{
			if (UserJoinRole == null)
				return;
			foreach (var userJoinRole in UserJoinRole.Where(item => item.RoleId == role.Id).ToList())
			{
				UserJoinRole.Remove(userJoinRole);
			}
		}

		public void DeleteRoleByRoleId(Guid roleId)
		{
			if (UserJoinRole == null)
				return;
			foreach (var userJoinRole in UserJoinRole.Where(item => item.RoleId == roleId).ToList())
			{
				UserJoinRole.Remove(userJoinRole);
			}
		}

		public void AddUserLanguage(UserLanguage userLanguage)
		{
			if (UserLanguages == null)
			{
				UserLanguages = new List<UserLanguage>();
			}
			else
			{
				if (UserLanguages.Any(item => item.EnumLanguage == userLanguage.EnumLanguage))
				{
					return;
				}
			}

			UserLanguages.Add(userLanguage);
		}

		public void DeleteUserLanguage(UserLanguage userLanguage)
		{
			UserLanguages?.Remove(userLanguage);
		}

		public void DeleteUserLanguage(Guid id)
		{
			UserLanguages?.Remove(UserLanguages.FirstOrDefault(item => item.Id == id)!);
		}

		public bool IsInRole(SystemRoleType systemRoleType)
		{
			return UserJoinRole.Any(item => item.Role.SystemRoleType == systemRoleType);
		}

		public bool IsInAnyRoles(List<SystemRoleType> systemRoleTypes)
		{
			return UserJoinRole.Any(item => systemRoleTypes.Contains(item.Role.SystemRoleType));
		}

		//public Resource GetAuthorizedResource()
		//{
		//	return Resources.FirstOrDefault(r => r.IsAuthorized && r.IsActive)
		//		   ?? Resources.FirstOrDefault(r => r.IsActive)
		//		   ?? new Resource()
		//		   {
		//			   Id = Guid.Empty
		//		   };
		//}
	}
}
