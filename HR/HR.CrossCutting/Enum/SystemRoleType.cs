using System.ComponentModel;

namespace HR.CrossCutting.Enum;
public enum SystemRoleType
{
	None = 0,

	[Description("Администратор"), Category("Translation")]
	Administrator = 1,
	[Description("Менеджер"), Category("Translation")]
	Manager = 2,
	[Description("Наблюдатель"), Category("Translation")]
	Auditor = 3,
	[Description("Пользователь"), Category("Translation")]
	User = 4,
	[Description("Локализатор"), Category("Translation")]
	Editor = 5,
	[Description("HR"), Category("Translation")]
	HR = 6,
	[Description("Работник"), Category("Translation")]
	Employee = 7,
	[Description("TopManager"), Category("Translation")]
	TopManager = 8,
	[Description("Руководитель проекта"), Category("Translation")]
	PM = 9,
	[Description("если текущий пользователь внесен в поле Руководитель сотрудника"), Category("Translation")]
	RM = 10,
	[Description("Если сотрудник связан с текущим пользователем"), Category("Translation")]
	Owner = 11,
	[Description("Если текущий пользователь внесен в поле Лид"), Category("Translation")]
	Lead = 12,
	[Description("если текущий пользователь внесен в поле Ментор"), Category("Translation")]
	Mentor = 13,
	[Description("Информационная безопасность"), Category("Translation")]
	InformationSecurity = 14,
	[Description("Проектный менеджер"), Category("Translation")]
	ProjectManager = 15,

	[Description("HR, которому доступна чать админки"), Category("Translation")]
	HRAdministrator = 20,
}
