using HR.Application.Graph.Resource.Types;
using HR.Application.Queries.Resource;
using HR.Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HR.Service.Handlers.Resources;
public class Edit
{
	public class Handler : IRequestHandler<EditCommand, ResourcePayload>
	{
		private readonly HrContext _context;

		public Handler(HrContext context)
		{
			_context = context;
		}

		public async Task<ResourcePayload> Handle(
			EditCommand message,
			CancellationToken cancellationToken
		)
		{
			var resource = await _context.Resources
				.Where(item => item.Id == message.Id)
				.FirstOrDefaultAsync(cancellationToken);
			if (resource == null)
			{
				throw new NullReferenceException("Сотрудник не найден");
			}

			resource.Email = "Ramanau_RG@st.by";
			resource.Validate();

			await _context.SaveChangesAsync(cancellationToken);

			resource = await _context.Resources
				.Where(item => item.Id == message.Id)
				.FirstOrDefaultAsync(cancellationToken);
			if (resource == null)
			{
				throw new NullReferenceException("Сотрудник не найден");
			}

			return new ResourcePayload
			{
				Id = resource.Id,
				Name = resource.Name ?? string.Empty,
				Email = resource.Email ?? string.Empty,
			};
		}
	}
}
