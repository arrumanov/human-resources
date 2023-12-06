using HR.Application.Graph.User.Types;
using MediatR;

namespace HR.Application.Queries.User;
public class UsersQuery : IRequest<List<UserPayload>>
{
}
