﻿using HotChocolate.AspNetCore;
using HotChocolate.Execution;
using System.Security.Claims;

namespace HR.Api.HttpHandler;

public class HttpRequestInterceptor : DefaultHttpRequestInterceptor
{
	public override ValueTask OnCreateAsync(HttpContext context,
		IRequestExecutor requestExecutor, IQueryRequestBuilder requestBuilder,
		CancellationToken cancellationToken)
	{
		var identity = new ClaimsIdentity();
		var rolesv = context.User.FindFirstValue("realm_access");
		if (rolesv != null)
		{
			dynamic roles = Newtonsoft.Json.Linq.JObject.Parse(rolesv);
			foreach (var r in roles.roles)
				identity.AddClaim(new Claim(ClaimTypes.Role, r.Value));
		}

		var namev = context.User.FindFirstValue("preferred_username");
		if (namev != null)
			identity.AddClaim(new Claim(ClaimTypes.Name, namev));

		context.User.AddIdentity(identity);

		return base.OnCreateAsync(context, requestExecutor, requestBuilder,
			cancellationToken);
	}
}
