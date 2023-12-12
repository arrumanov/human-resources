using HR.Api.HttpHandler;
using HR.Application.Graph.User.Query;
using HR.Application.Graph.Resource.Query;
using HR.Application.Queries.User;
using HR.Infrastructure.AppSetting;
using HR.Infrastructure.DataAccess;
using HR.Service.Handlers.Users;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using HR.Infrastructure.Services;
using HR.Service.Services;
using HR.Infrastructure.SearchEngine.Api;
using HR.Infrastructure.SearchEngine.Impl;
using System.Reflection;
using HR.Application.Graph.Resource.Mutation;

var builder = WebApplication.CreateBuilder(args);

var serviceKeycloakSection = builder.Configuration.GetSection("Keycloak");
builder.Services.Configure<Keycloak>(serviceKeycloakSection);
var keycloakSettings = serviceKeycloakSection.Get<Keycloak>();

builder.Services.AddDataAccess(builder.Configuration.GetConnectionString("HrDb")!);

builder.Services.AddCors(options =>
{
	options.AddPolicy("DefaultPolicy", builder =>
	{
		builder.AllowAnyHeader()
			.WithMethods("GET", "POST")
			.WithOrigins("*");
	});
});

builder.Services.AddTransient<ISearchService, SearchService>();
//builder.Services.AddTransient<ISearchEngine, SearchEngine>();
builder.Services.AddTransient<ISearchEngine, SearchEngine>(
			provider => new SearchEngine(
				Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!
			)
		);

builder.Services.AddHttpContextAccessor();

#region AddAuthentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
	.AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, config =>
	{
		config.TokenValidationParameters = new TokenValidationParameters
		{
			ClockSkew = TimeSpan.FromSeconds(5),
			ValidateAudience = false
		};
		config.RequireHttpsMetadata = false;
		//OAUTH 2.0 
		config.Authority = $"{keycloakSettings!.RealmsUrl}{keycloakSettings.Realm}/";
		config.Audience = keycloakSettings.Client;
	});
#endregion

#region HttpClient "auth"
builder.Services
	.AddHttpClient(keycloakSettings!.HttpClient)
	.AddHttpMessageHandler<HttpTrackerHandler>();
#endregion

builder.Services.AddHttpContextAccessor();
builder.Services.AddAuthorization();

builder.Services.AddMediatR(cfg =>
{
	cfg.RegisterServicesFromAssembly(typeof(UsersQuery).Assembly);
	cfg.RegisterServicesFromAssembly(typeof(List).Assembly);
});

builder.Services
	.AddGraphQLServer()
	.AddHttpRequestInterceptor<HttpRequestInterceptor>()
	.AddAuthorization()
	.AddQueryType()
	.AddTypeExtension<ResourceQuery>()
	.AddTypeExtension<UserQuery>()
	.AddMutationType()
	.AddTypeExtension<ResourceMutation>();

// Add services to the container.
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseCors("DefaultPolicy");

app.MapGraphQL();

app.Run();
