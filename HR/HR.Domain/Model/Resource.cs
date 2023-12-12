using FluentValidation;
using HR.CrossCutting.Constants;
using HR.CrossCutting.Enum;
using HR.Domain.Utils.CustomFieldUtil;
using HR.Domain.Validator;

namespace HR.Domain.Model;
public class Resource
{
	private string? _name;

	public Guid Id { get; set; }
	public string? Name
	{
		get => _name;
		set
		{
			_name = value!.Trim();
			if (_name.Length > 253)
			{
				_name = string.Concat(_name.AsSpan(0, 252), "...");
			}
		}
	}
	public bool IsActive { get; set; }
	public bool IsExternal { get; set; }
	public bool IsAuthorized { get; set; }
	public Guid? UserId { get; set; }
	public decimal Rate { get; set; }
	public DateTime DateOfEmployment { get; set; }
	public DateTime? DateOfTermination { get; set; }
	public Guid? UpperUnitId { get; set; }
	public string? Email { get; set; }
	public Guid? DepartmentId { get; set; }
	public Guid? PositionId { get; set; }
	public Guid? StatusId { get; set; }
	public Guid? ResourceManagerId { get; set; }
	public bool? IsExpertCareerDevelopmentDay { get; set; }
	public bool? IsKDRCompleted { get; set; }
	public DateTime? Birthday { get; set; }

	#region Navigation properties
	public List<Translation> Translations { get; set; } = [];
	public List<CustomFieldValue> CustomFieldValues { get; set; } = [];
	public List<Permission> Permissions { get; set; } = [];
	public List<Permission> PermissionsForObject { get; set; } = [];
	public List<HeadOfDepartment> HeadOfDepartments { get; set; } = [];
	public List<HeadOfDepartment> DeputyHeads { get; set; } = [];
	public DictionaryValue? Department { get; set; }
	public DictionaryValue? Position { get; set; }
	public DictionaryValue? Status { get; set; }
	public Resource? ResourceManager { get; set; }
	public DictionaryValue? UpperUnit { get; set; }

	private readonly List<ResourceUniqKey> _resourceKeys = [];
	public IReadOnlyCollection<ResourceUniqKey> ResourceKeys => _resourceKeys;

	private List<ObjectColor> _resourceColors = [];
	public List<ObjectColor> ResourceColors
	{
		get => _resourceColors;
		set => _resourceColors = value;
	}

	private List<Favorite> _favorites = [];
	public List<Favorite> Favorites
	{
		get => _favorites;
		set => _favorites = value;
	}

	#endregion


	public Resource()
	{
		_resourceKeys = [];
		Rate = 1m;
	}


	protected Resource(Guid id, bool isActive, bool isExternal, string name, DateTime dateOfEmployment)
		: this()
	{
		IsActive = isActive;
		IsExternal = isExternal;
		Id = id;
		Name = name;
		DateOfEmployment = dateOfEmployment;
	}

	public Resource(bool isActive, bool isExternal, string name, DateTime dateOfEmployment)
		: this(Guid.NewGuid(), isActive, isExternal, name, dateOfEmployment)
	{
	}

	public void Validate()
	{
		var validator = new ResourceValidator();

		var validationResult = validator.Validate(this);

		if (!validationResult.IsValid) 
			throw new ValidationException(string.Join(";", validationResult.Errors
				.Select(i => i.ErrorCode)
				.Where(f => f != null)
				.ToList()));
	}

	public string GetLocalizedName(EnumLanguage language = EnumLanguage.Default)
	{
		var localized = Translations.FirstOrDefault(item => item.Language == language) ??
						Translations.FirstOrDefault(item => item.Language == EnumLanguage.Default);

		return localized == null ? Name??string.Empty : localized.Text??string.Empty;
	}

	public string GetColor(Guid? userId)
	{
		return userId.HasValue ?
			ResourceColors.FirstOrDefault(item => item.UserId == userId)?.HexColor ?? SystemConfig.DefaultColor
			: SystemConfig.DefaultColor;
	}

	public bool IsFavorite(Guid userId)
	{
		return Favorites != null && Favorites.Any(item => item.UserId == userId);
	}

	public void SetValue(string value, string fieldKey)
	{
		if (fieldKey == FieldKeyConst.CFObjectName)
		{
			Name = value.Trim();
		}
		else if (fieldKey == FieldKeyConst.CFEmail)
		{
			Email = value.Trim();
		}
		else if (fieldKey == FieldKeyConst.CFIsActive)
		{
			bool.TryParse(value, out bool newValueIsActive);
			IsActive = newValueIsActive;
		}
		else if (fieldKey == FieldKeyConst.CFIsExternal)
		{
			bool.TryParse(value, out bool newValueIsExternal);
			IsExternal = newValueIsExternal;
		}
		else if (fieldKey == FieldKeyConst.CFRate)
		{
			decimal.TryParse(value, out decimal newValueRate);
			Rate = newValueRate;
		}
		else if (fieldKey == FieldKeyConst.CFDateOfTermination)
		{
			if (value == null)
			{
				DateOfTermination = null;
			}
			else
			{
				DateTime.TryParse(value, out DateTime newValueDateOfTermination);
				DateOfTermination = newValueDateOfTermination;
			}
		}
		else if (fieldKey == FieldKeyConst.CFUnit)
		{
			if (Guid.TryParse(value, out Guid newValue))
			{
				DepartmentId = newValue;
			}
			else
			{
				DepartmentId = null;
			}
		}
		else if (fieldKey == FieldKeyConst.CFPosition)
		{
			if (Guid.TryParse(value, out Guid newValue))
			{
				PositionId = newValue;
			}
			else
			{
				PositionId = null;
			}
		}
		else if (fieldKey == FieldKeyConst.CFStatus)
		{
			if (Guid.TryParse(value, out Guid newValue))
			{
				StatusId = newValue;
			}
			else
			{
				StatusId = null;
			}
		}
		else if (fieldKey == FieldKeyConst.CFResourceManager)
		{
			if (Guid.TryParse(value, out Guid newValue))
			{
				ResourceManagerId = newValue;
			}
			else
			{
				ResourceManagerId = null;
			}
		}
		else if (fieldKey == FieldKeyConst.CFDateOfEmployment)
		{
			if (DateTime.TryParse(value, out DateTime newValueDate))
			{
				DateOfEmployment = newValueDate;
			}
			else
			{
				DateOfEmployment = DateTime.MinValue;
			}
		}
		else
		{
			throw new ArgumentOutOfRangeException();
		}
	}

	public void SetValue(List<CustomFieldValueItem> value, string fieldKey)
	{
		if (fieldKey == FieldKeyConst.CFObjectName)
		{
			Name = value?.FirstOrDefault()?.Value?.Trim();
		}
		else if (fieldKey == FieldKeyConst.CFEmail)
		{
			Email = value?.FirstOrDefault()?.Value?.Trim();
		}
		else if (fieldKey == FieldKeyConst.CFIsActive)
		{
			if (bool.TryParse(value?.FirstOrDefault()?.Value, out bool newValueIsActive))
			{
				IsActive = newValueIsActive;
			}
		}
		else if (fieldKey == FieldKeyConst.CFIsExternal)
		{
			if (bool.TryParse(value?.FirstOrDefault()?.Value, out bool newValueIsExternal))
			{
				IsExternal = newValueIsExternal;
			}
		}
		else if (fieldKey == FieldKeyConst.CFRate)
		{
			if (decimal.TryParse(value?.FirstOrDefault()?.Value, out decimal newValueRate))
			{
				Rate = newValueRate;
			}
		}
		else if (fieldKey == FieldKeyConst.CFDateOfTermination)
		{
			if (DateTime.TryParse(value?.FirstOrDefault()?.Value, out DateTime newValueDateOfTermination))
			{
				DateOfTermination = newValueDateOfTermination;
			}
			else
			{
				DateOfTermination = null;
			}
		}
		else if (fieldKey == FieldKeyConst.CFUnit)
		{
			if (Guid.TryParse(value?.FirstOrDefault()?.Value, out Guid newValue))
			{
				DepartmentId = newValue;
				UpperUnitId = newValue;
			}
			else
			{
				DepartmentId = null;
				UpperUnitId = null;
			}
		}
		else if (fieldKey == FieldKeyConst.CFPosition)
		{
			if (Guid.TryParse(value?.FirstOrDefault()?.Value, out Guid newValue))
			{
				PositionId = newValue;
			}
			else
			{
				PositionId = null;
			}
		}
		else if (fieldKey == FieldKeyConst.CFStatus)
		{
			if (Guid.TryParse(value?.FirstOrDefault()?.Value, out Guid newValue))
			{
				StatusId = newValue;
			}
			else
			{
				StatusId = null;
			}
		}
		else if (fieldKey == FieldKeyConst.CFResourceManager)
		{
			if (Guid.TryParse(value?.FirstOrDefault()?.Value, out Guid newValue))
			{
				ResourceManagerId = newValue;
			}
			else
			{
				ResourceManagerId = null;
			}
		}
		else if (fieldKey == FieldKeyConst.CFDateOfEmployment)
		{
			if (DateTime.TryParse(value?.FirstOrDefault()?.Value, out DateTime newValueDate))
			{
				DateOfEmployment = newValueDate;
			}
			else
			{
				DateOfEmployment = DateTime.MinValue;
			}
		}
		else
		{
			throw new ArgumentOutOfRangeException();
		}
	}
}
