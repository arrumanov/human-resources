using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HR.Infrastructure.DataAccess
{
	public static class EntityFrameworkInstaller
	{
		public static IServiceCollection AddDataAccess(this IServiceCollection services, string cnnString)
		{
			services.AddDbContext<HrContext>(options =>
			{
				options.UseSqlServer(cnnString);
			});

			return services;
		}
	}
}
