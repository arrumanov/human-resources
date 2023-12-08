using HR.Infrastructure.SearchEngine.Models;

namespace HR.Infrastructure.SearchEngine.Api;
public interface ISearchEngine : IDisposable
{
	void BuildIndex(BuildIndexRequest request);
	void RemoveIndexAll();
	void RemoveIndex(BuildIndexRequest request);
	SearchResponse Search(SearchRequest request);
}
