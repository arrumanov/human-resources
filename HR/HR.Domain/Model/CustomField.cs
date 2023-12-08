using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;

namespace HR.Domain.Model;
public class CustomField
{
	#region Props

	private string? _name;
	protected IFillCustomFieldProps FillBehaviour;

	public Guid Id { get; set; }
	public string? Name
	{
		get => _name;
		set => _name = value!.Trim();
	}
	public CustomFieldType Type { get; set; }
	public string FieldKey { get; protected set; } = default!;
	public string? DictionaryKey { get; set; }
	public string? DictionaryOfLevelsKey { get; set; }
	public bool IsBanOnRemoval { get; set; }
	public CustomFieldCategory Category { get; set; }
	public string? Description { get; set; }

	#endregion

	#region Navigation properties

	public List<Translation> Translations { get; set; } = new ();
	public Dictionary? Dictionary { get; set; }
	public Dictionary? DictionaryOfLevels { get; set; }
	public List<CustomFieldReference> CustomFieldReferences { get; set; } = new();

	#endregion

	protected CustomField()
	{
		FillBehaviour = new FillDefault();
	}

	protected CustomField(Guid id, string name)
		: this()
	{
		Id = id;
		Name = name;
	}

	public CustomField(string name)
		: this(Guid.NewGuid(), name)
	{
	}

	public CustomField(string name, string fieldKey)
		: this(Guid.NewGuid(), name)
	{
		FieldKey = fieldKey;
	}
	/// <summary>
	/// Заполнение полей классов-наследников сущности CustomField через Dto
	/// </summary>
	/// <param name="customFieldDto"></param>
	public void FillProps(CustomFieldDto customFieldDto)
	{
		FillBehaviour.FillCustomFieldProps(this, customFieldDto);
	}

	/// <summary>
	/// Проверка на необходимость удаления CustomFieldValues в зависимости от передаваемого типа
	/// </summary>
	/// <returns></returns>
	public virtual bool IsValueRemovable(CustomFieldType customFieldType)
	{
		if (Type == customFieldType)
		{
			return false;
		}
		return true;
	}
	/// <summary>
	/// Проверка на необходимость удаления CustomFieldValue Translation в зависимости от передаваемого типа
	/// </summary>
	/// <param name="customFieldType"></param>
	/// <returns></returns>
	public virtual bool IsDeleteValueTranslation(CustomFieldType customFieldType)
	{
		return true;
	}

	public virtual bool IsValueDictionaryRequired(CustomFieldType customFieldType)
	{
		return false;
	}
	/// <summary>
	/// Получить список CustomFieldValues для изменения в зависимости от типа CustomField
	/// </summary>
	/// <param name="entity"></param>
	/// <param name="customFieldValues"></param>
	/// <param name="dictionaryValues"></param>
	/// <returns></returns>
	public virtual List<CustomFieldValue> GetValuesForUpdate(CustomField entity, List<CustomFieldValue> customFieldValues,
		List<DictionaryValue> dictionaryValues)
	{
		var updateCustomFieldValues = new List<CustomFieldValue>();
		return updateCustomFieldValues;
	}

	public string GetLocalizedName(EnumLanguage? language)
	{
		var localized = Translations.FirstOrDefault(item => item.Language == language) ??
						Translations.FirstOrDefault(item => item.Language == EnumLanguage.Default);

		return localized == null ? Name??string.Empty : localized.Text??string.Empty;
	}
}
