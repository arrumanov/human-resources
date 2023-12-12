using HR.CrossCutting.Enum;
using HR.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace HR.Infrastructure.Extensions;
public static class ResourceDbSetExtensions
{
	public static IQueryable<Resource> GetAllData(this DbSet<Resource> query) =>
		query
			.Include(item => item.Translations)
			.Include(item => item.ResourceColors)
			.Include(item => item.Favorites)
			.Include(item => item.Position)
			.ThenInclude(p => p.Translations)
			.AsNoTracking();

	public static IQueryable<Resource> GetFull(this DbSet<Resource> query) =>
		query
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
			.AsNoTracking();

	public static IQueryable<Resource> Sort(this IQueryable<Resource> query, BizObjectSort? sortType)
	{
		return sortType switch
		{
			BizObjectSort.Asc => query.OrderBy(item => item.Name),
			BizObjectSort.Desc => query.OrderByDescending(item => item.Name),
			_ => query
		};
	}

	public static IQueryable<Resource> Paged(this IQueryable<Resource> query, int? page, int? pageSize)
	{
		if (!page.HasValue || page < 1)
			page = 1;
		if (!pageSize.HasValue || pageSize < 1 || pageSize > 1000)
			pageSize = 100;

		return query.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value);
	}
}
