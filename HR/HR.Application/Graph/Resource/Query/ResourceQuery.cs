using HotChocolate;
using HotChocolate.Authorization;
using HotChocolate.Types;
using HR.Application.Graph.Common;
using HR.Application.Graph.Resource.Types;
using HR.Application.Queries.Resource;
using HR.CrossCutting.Constants;
using MediatR;

namespace HR.Application.Graph.Resource.Query;

[Authorize(Roles = [RolesConst.USER_HR])]
[ExtendObjectType(OperationTypeNames.Query)]
public class ResourceQuery
{
	public async Task<ResourcesPayload> GetResources(
		FilterSortInput input,
		[Service] IMediator mediator,
		CancellationToken cancellationToken)
	{
		var message = new ResourcesQuery
		{
			Filters = input.Filters,
			MainSort = input.MainSort,
			Page = input.Page,
			PageSize = input.PageSize
		};
		var payload = await mediator.Send(message, cancellationToken);
		return payload;
	}
}
