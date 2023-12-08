namespace HR.CrossCutting.Extentions;
public static class GuidExtentions
{
	public static string ToFormatString(this Guid value)
	{
		return value.ToString().ToLower();
	}
}
