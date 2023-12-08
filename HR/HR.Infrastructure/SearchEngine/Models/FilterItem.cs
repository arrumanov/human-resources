using HR.CrossCutting.Enum;

namespace HR.Infrastructure.SearchEngine.Models;
public class FilterItem
{
	public string CustomFieldId { get; set; } = default!;
	public FilterValue FilterValue { get; set; } = default!;
	public FilterEnumType FilterType { get; set; }
	public TabType TabType { get; set; }
}
