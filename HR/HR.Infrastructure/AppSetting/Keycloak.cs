namespace HR.Infrastructure.AppSetting
{
	public class Keycloak
	{
		public string RealmsUrl { get; set; } = default!;
		public string RealmUsersByRole { get; set; } = default!;
		public string IdClient { get; set; } = default!;
		public string RequestTokenUrl { get; set; } = default!;
		public string HttpClient { get; set; } = default!;
		public string Realm { get; set; } = default!;
		public string Client { get; set; } = default!;
		public string UserName { get; set; } = default!;
		public string PasswordName { get; set; } = default!;
		public string UrlProject { get; set; } = default!;
	}
}
