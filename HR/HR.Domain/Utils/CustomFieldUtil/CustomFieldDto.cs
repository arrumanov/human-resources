using HR.CrossCutting.Enum;

namespace HR.Domain.Utils.CustomFieldUtil;
public class CustomFieldDto
{
	public Guid Id { get; set; }
	public string FieldKey { get; set; } = default!;
	public string FieldName { get; set; } = default!;
	public CustomFieldType FieldType { get; set; }
	public string? DictionaryKey { get; set; }
	public string? DictionaryOfLevelsKey { get; set; }
	public bool IsBanOnRemoval { get; set; }
	public CustomFieldCategory Category { get; set; }
	public string? Description { get; set; }
}
