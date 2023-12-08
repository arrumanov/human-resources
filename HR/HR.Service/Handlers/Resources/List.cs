using HR.Application.Queries.Resource;
using HR.Application.Graph.Resource.Types;
using HR.Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;
using HR.Infrastructure.Services;
using HR.CrossCutting.Enum;

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
			var filterItems = message.Filters[ObjectType.Resource];
			var resourcesId = new List<Guid>();
			if (filterItems.Count > 0)
			{
				resourcesId = _srvcSearch.GetResourcesId(filterItems);
			}

			var resources = await _context.Resources
				.Include(item => item.Translations)
				.Include(item => item.CustomFieldValues)
				.Include(item => item.Position)
				.ThenInclude(p => p.Translations)
				.Include(item => item.Status)
				.ThenInclude(s => s.Translations)
				.Include(item => item.ResourceManager)
				.ThenInclude(rm => rm.Translations)
				.Include(item => item.PermissionsForObject)
				//.ThenInclude(po => po.ObjectResource)
				//.ThenInclude(or => or.Translations)
				.Include(item => item.ResourceColors)
				.Where(item => resourcesId.Count > 0 ? resourcesId.Contains(item.Id) : true)
				.OrderBy(item => item.Name)
				.Take(10)
				.AsNoTracking()
				.ToListAsync(cancellationToken);
			var count = _context.Resources
				.Where(item => resourcesId.Count > 0 ? resourcesId.Contains(item.Id) : true)
				.Count();

			var list = resources.Select(item => new Resource
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
