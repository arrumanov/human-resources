namespace HR.Infrastructure.SearchEngine.Models;
public class SearchResponse
{
	public SearchResponse() => ObjectsId = new List<Guid>();
	public int TotalCount { get; set; }
	public IList<Guid> ObjectsId { get; set; }
}
