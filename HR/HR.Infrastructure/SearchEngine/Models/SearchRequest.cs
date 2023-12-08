namespace HR.Infrastructure.SearchEngine.Models;
public class SearchRequest
{
	public string KeyIndex { get; set; }
	public SearchRequest(string keyIndex) => KeyIndex = keyIndex;
	public SearchRequest(List<Filter> filters) => Filters = filters;
	public List<Filter> Filters { get; set; } = [];
}
