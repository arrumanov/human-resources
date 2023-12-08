using System.Globalization;

namespace HR.CrossCutting.Extentions;
public static class DecimalExtentions
{
	public static string ToFormatString(this decimal value)
	{
		return value.ToString("N4", CultureInfo.CreateSpecificCulture("ru-RU")).ToLower();
	}
}
