using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace HR.Infrastructure.Extensions;
public static class HttpContextAccessorExtension
{
	public static bool HasRole(this IHttpContextAccessor httpContextAccessor, string role)
	{
		var realmAccess = httpContextAccessor.HttpContext?.User.FindFirstValue("realm_access");
		if (realmAccess != null && realmAccess.Contains(role))
			return true;

		return false;
	}
}
