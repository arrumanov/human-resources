using HotChocolate;
using HotChocolate.Authorization;
using HotChocolate.Types;
using HR.Application.Graph.User.Types;
using HR.Application.Queries.User;
using HR.CrossCutting.Constants;
using MediatR;

namespace HR.Application.Graph.User.Query;

[Authorize(Roles = [RolesConst.USER_HR])]
[ExtendObjectType(OperationTypeNames.Query)]
public class UserQuery
{
	public async Task<List<UserPayload>> GetUsers([Service] IMediator mediator, CancellationToken cancellationToken)
	{
		var payload = await mediator.Send(new UsersQuery(), cancellationToken);
		return payload;
	}
}
