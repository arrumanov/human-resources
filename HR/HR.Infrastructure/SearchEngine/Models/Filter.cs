namespace HR.Infrastructure.SearchEngine.Models;
public class Filter
{
	public string Key { get; set; } = default!;
	public List<string> Values { get; set; } = [];
	public FilterMode FilterMode { get; set; }
}
