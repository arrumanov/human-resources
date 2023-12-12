using HotChocolate;
using HotChocolate.Authorization;
using HotChocolate.Types;
using HR.Application.Graph.Resource.Types;
using HR.Application.Queries.Resource;
using HR.CrossCutting.Constants;
using MediatR;

namespace HR.Application.Graph.Resource.Mutation;

[Authorize(Roles = [RolesConst.USER_HR])]
[ExtendObjectType(OperationTypeNames.Mutation)]
public class ResourceMutation
{
	public async Task<ResourcePayload> Edit(
		EditInput input,
		[Service] IMediator mediator,
		CancellationToken cancellationToken)
	{
		var message = new EditCommand
		{
			Id = input.Id,
		};
		return await mediator.Send(message, cancellationToken);
	}
}
