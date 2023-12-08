namespace HR.CrossCutting.Constants;
public static class UtilityConst
{
	public const string Splitter = "#splitter#";

	public const string SplitterBetweenTagAndLevel = "#spl_lvl#";
	public const string SplitterCustomField = "_spl_cf_";

	public const string ProfileCustomFieldPrefix = "profile_";

	public const string EmptyTaskId = "00000000-0000-0000-0000-000000000002";

	public const string StartDate1C = "1900-01-01T00:00:00";

	//разделители для выгрузки в Excel
	public const string ExcelSplitter = "; ";
	public const string ExcelSplitterBetweenTagAndLevelStart = "[";
	public const string ExcelSplitterBetweenTagAndLevelEnd = "]";

	public static class ValidationRegex
	{
		public static string LoginRegex = @"\s{0,}ST_DOMAIN\\[\w]{1,}\s{0,}";
		public static string ValidCharactersRegex = @"\s{0,}(?!\s).*\S{1,}\s{0,}";
		public static string ValidCharactersCommonRegex = "/[0-9a-zA-Zа-яА-Я%*()+=\\-:\"';?\\/., №]*/gim";
	}
}
