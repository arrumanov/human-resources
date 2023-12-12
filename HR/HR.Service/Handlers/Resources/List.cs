using HR.Application.Queries.Resource;
using HR.Application.Graph.Resource.Types;
using HR.Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;
using HR.Infrastructure.Services;
using HR.CrossCutting.Enum;
using HR.Infrastructure.Extensions;
using HR.Domain.Model;
using System.Linq.Expressions;

namespace HR.Service.Handlers.Resources;
public class List
{
	public class QueryHandler : IRequestHandler<ResourcesQuery, ResourcesPayload>
	{
		private readonly HrContext _context;
		private readonly ISearchService _srvcSearch;

		public QueryHandler(HrContext context, ISearchService srvcSearch)
		{
			_context = context;
			_srvcSearch = srvcSearch;
		}

		public async Task<ResourcesPayload> Handle(
			ResourcesQuery message,
			CancellationToken cancellationToken
		)
		{
			//var ids = await _context.Resources.Select(item => item.Id).ToListAsync();
			//await _srvcSearch.BuildIndex(ids, SearchConst.ResourceIndex, ObjectType.Resource);
			var queryable = _context.Resources.GetAllData();

			var filterItems = message.Filters![ObjectType.Resource];
			var resourcesId = new List<Guid>();
			Expression<Func<Resource, bool>> func = (item) => true;
			if (filterItems.Count > 0)
			{
				resourcesId = _srvcSearch.GetResourcesId(filterItems);
				func = (item) => resourcesId.Count > 0 ? resourcesId.Contains(item.Id) : true;
			}

			var resources = await queryable
				.Where(func)
				.Sort(message.MainSort)
				.Paged(message.Page, message.PageSize)
				.ToListAsync(cancellationToken);
			var count = _context.Resources
				.Where(func)
				.Count();

			var list = resources.Select(item => new ResourcePayload
			{
				Id = item.Id,
				Name = item.Name??string.Empty,
				Email = item.Email??string.Empty,
			}).ToList();


			return new ResourcesPayload
			{
				List = list,
				Count = count
			};
		}
	}
}
