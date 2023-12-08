using HR.CrossCutting.Enum;

namespace HR.CrossCutting.Constants;
public static class SystemConfig
{
	public static EnumLanguage DefaultSystemLanguage = EnumLanguage.Ru;

	public static string DefaultColor = "#ffd503";
	public static string DefaultImageResource = "/images/ic-default-profile.png";
	public static string DefaultImageProject = "/images/ic-default-projects.png";
	public static string ImageEdit = "/images/ic_image_edit.png";
	public static string FieldImgAvatar = "imgObjectAvatarEdit";
	public static IReadOnlyDictionary<ObjectType, string> DefaultImageBase64Dictionary = new Dictionary<ObjectType, string>
	{
		{
			ObjectType.Project, "iVBORw0KGgoAAAANSUhEUgAAABQAAAAUCAYAAACNiR0NAAAAqElEQVQ4T2Pcvn37fwYqAU9PT0bGoWmgpaUlAz8/P86A+PTpE8OxY8cw5HF62cPDg2Co7tixg3QDP3z4AHbp06dPGX78+AE2QEVFBUyTZeCbN28YREREGG7evMnw8eNHsEFmZmbkG4jP32S5EJsmWPiSZeAId6G+vj4DKBlpamoOglh2c3NjYGJiwhkn//79Y9i1axfxOYVgvsOhYAgXXxR5mVzNuPQBAGTclBVBVDuOAAAAAElFTkSuQmCC"
		},
		{
			ObjectType.Resource, "iVBORw0KGgoAAAANSUhEUgAAABQAAAAUCAYAAACNiR0NAAAA/klEQVQ4T+2UQYtAQBzFHyKOHCUnvoADd1J8YsoXkIuTkoNcFAdSXNlttnbbXbMm2svWvprbvF/zf/NmuCRJXvBLiuOY4/6BpzRVVYXjOBiGAVVVXabNzNCyLJD1rn3fkWXZj1AmMIqikznPcyzLQoU+ApZliXEc7wNFUUQQBCdj27ZomuY+kDh834ckSV/MJEOSJU3MkQVBQBiGH966rtF13fNLIU6e52GaJqZpwrquz2qj6zps24aiKNi27a2DsizDMAwcx4G+76mdpI6saRpc12V+F6Q6pEKfRQV+L/MVOU1TNpA8Nc/zmCec5xlFUbCBTNLFBmZt7sL/BvAVBeCeFZ60T+IAAAAASUVORK5CYII="
		},
		{
			ObjectType.User, "iVBORw0KGgoAAAANSUhEUgAAABQAAAAUCAYAAACNiR0NAAAA/klEQVQ4T+2UQYtAQBzFHyKOHCUnvoADd1J8YsoXkIuTkoNcFAdSXNlttnbbXbMm2svWvprbvF/zf/NmuCRJXvBLiuOY4/6BpzRVVYXjOBiGAVVVXabNzNCyLJD1rn3fkWXZj1AmMIqikznPcyzLQoU+ApZliXEc7wNFUUQQBCdj27ZomuY+kDh834ckSV/MJEOSJU3MkQVBQBiGH966rtF13fNLIU6e52GaJqZpwrquz2qj6zps24aiKNi27a2DsizDMAwcx4G+76mdpI6saRpc12V+F6Q6pEKfRQV+L/MVOU1TNpA8Nc/zmCec5xlFUbCBTNLFBmZt7sL/BvAVBeCeFZ60T+IAAAAASUVORK5CYII="
		}
	};
}
