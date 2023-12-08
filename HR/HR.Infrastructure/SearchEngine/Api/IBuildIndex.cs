namespace HR.Infrastructure.SearchEngine.Api;
public interface IBuildIndex
{
	void BuildIndex();
	void BuildIndex(Guid objectId);
	void BuildIndex(List<Guid> objectId);
	void RemoveInIndex(Guid objectId);
	void RemoveInIndex(List<Guid> objectId);
}
