using HR.Application.Graph.User.Types;
using HR.Application.Queries.User;
using HR.Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HR.Service.Handlers.Users;
public class List
{
	public class QueryHandler : IRequestHandler<UsersQuery, List<UserPayload>>
	{
		private readonly HrContext _context;

		public QueryHandler(HrContext context)
		{
			_context = context;
		}

		public async Task<List<UserPayload>> Handle(
			UsersQuery message,
			CancellationToken cancellationToken
		)
		{
			var users = await _context.Users
				.Take(10)
				.AsNoTracking()
				.ToListAsync(cancellationToken);

			var payload = users.Select(item => new UserPayload
			{
				Id = item.Id,
				Name = item.Name,
				Login = item.Login,
				Email = item.Email,
			}).ToList();

			return payload;
		}
	}
}
