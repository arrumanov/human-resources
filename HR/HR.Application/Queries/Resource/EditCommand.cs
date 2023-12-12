using HR.Application.Graph.Resource.Types;
using MediatR;

namespace HR.Application.Queries.Resource;
public class EditCommand : IRequest<ResourcePayload>
{
	public Guid Id { get; set; }
}
