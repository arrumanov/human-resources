namespace HR.Infrastructure.SearchEngine.Models;
public class FilterValue
{
	public List<string> StringValue { get; set; } = [];
	public Dictionary<string, List<string>> TagWithLevels { get; set; } = [];
	public DateTime? DateFrom { get; set; }
	public DateTime? DateTo { get; set; }
	public int? TimeTolerance { get; set; }
	public bool IsForeachDay { get; set; }

	public int? RangeIntFrom { get; set; }
	public int? RangeIntTo { get; set; }
}
