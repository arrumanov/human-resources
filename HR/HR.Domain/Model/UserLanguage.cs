using HR.CrossCutting.Enum;

namespace HR.Domain.Model
{
	public class UserLanguage
	{
		protected UserLanguage()
		{
		}


		protected UserLanguage(Guid id, Guid userId, string smallName, EnumLanguage enumLanguage)
			: this()
		{
			Id = id;
			UserId = userId;
			SmallName = smallName;
			EnumLanguage = enumLanguage;
		}

		public UserLanguage(Guid userId, string smallName, EnumLanguage defaultEnumLanguage)
			: this(Guid.NewGuid(), userId, smallName, defaultEnumLanguage)
		{
		}

		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public string SmallName { get; set; } = default!;
		public EnumLanguage EnumLanguage { get; set; }
	}
}
