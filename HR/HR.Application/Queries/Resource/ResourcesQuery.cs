using HR.Application.Graph.Resource.Types;
using HR.CrossCutting.Enum;
using HR.Infrastructure.SearchEngine.Models;
using MediatR;

namespace HR.Application.Queries.Resource;
public class ResourcesQuery : IRequest<ResourcesPayload>
{
	public Dictionary<ObjectType, List<FilterItem>>? Filters { get; set; } = [];
	public BizObjectSort? MainSort { get; set; }
	public int? Page { get; set; }
	public int? PageSize { get; set;}
}
