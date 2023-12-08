using HR.CrossCutting.Enum;

namespace HR.Domain.Model;
public class CustomFieldReference
{
	#region props

	public Guid Id { get; set; }
	public string FieldKey { get; set; } = default!;
	public ObjectType ObjectType { get; set; }
	public TabType TabType { get; set; }
	public int Sequence { get; set; }
	public bool IsTranslated { get; set; }
	public bool IsRequired { get; set; }
	public bool IsReadOnly { get; set; }
	public bool IsNeedForCreation { get; set; }
	public bool IsInEntity { get; set; }
	public decimal? NumericStep { get; set; }
	public Dictionary<string, string> EventHandlers { get; set; } = new();
	public Dictionary<string, string> Props { get; set; } = new();
	public List<SystemRoleType> AccessBySystemRoleTypes { get; set; } = new();

	#endregion

	#region NavigationProperties

	public CustomField CustomField { get; set; } = default!;
	public List<Translation> Translations { get; set; } = new();


	#endregion
	protected CustomFieldReference()
	{
	}

	public CustomFieldReference(Guid id, string fieldKey, ObjectType objectType, TabType tabType, int sequence)
		: this()
	{
		Id = id;
		FieldKey = fieldKey;
		ObjectType = objectType;
		TabType = tabType;
		Sequence = sequence;
	}
	public CustomFieldReference(string fieldKey, ObjectType objectType, TabType tabType, int sequence)
		: this(Guid.NewGuid(), fieldKey, objectType, tabType, sequence)
	{
	}

	public string GetLocalizedName(EnumLanguage? language)
	{
		var localized = Translations.FirstOrDefault(item => item.Language == language) ??
						Translations.FirstOrDefault(item => item.Language == EnumLanguage.Default);

		return localized == null ? "Error" : localized.Text??string.Empty;
	}

	/// <summary>
	/// Является ли поле ReadOnly в зависимости от ролей пользователя
	/// </summary>
	/// <param name="roles"></param>
	/// <returns></returns>
	public bool IsReadonly(List<SystemRoleType> roles)
	{
		if (IsReadOnly)
		{
			return true;
		}
		var result = ObjectType switch
		{
			ObjectType.Resource or
				ObjectType.Questionnaire or
				ObjectType.Adaptation or
				ObjectType.Mentorship or
				ObjectType.Meeting or
				ObjectType.Mentoring or
				ObjectType.Training or
				ObjectType.Trainee or
				ObjectType.PersonnelReserve or
				ObjectType.PositionResponse or
				ObjectType.ExitInterview or
				ObjectType.KeyResource or
				ObjectType.DismissalRequest or
				ObjectType.Gratitude
				=> AccessBySystemRoleTypes?.Count > 0 && AccessBySystemRoleTypes.All(role => !roles.Contains(role)),
			ObjectType.Project or
				ObjectType.Task or
				ObjectType.User or
				ObjectType.Attendance
				=> false,
			_ => throw new ArgumentOutOfRangeException($"Тип объекта {ObjectType} не предусматривает логику обработки свойста IsReadOnly"),
		};
		return result;
	}
}
