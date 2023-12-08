using HR.CrossCutting.Enum;

namespace HR.Domain.Model;
public class ObjectColor
{
	public Guid Id { get; set; }
	public string HexColor { get; set; } = default!;
	public Guid ObjectId { get; set; }
	public Guid UserId { get; set; }
	public ObjectType ObjectType { get; set; }

	public ObjectColor()
	{
	}

	public ObjectColor(Guid id, string hexColor, Guid objectId, Guid userId, ObjectType objectType)
		: this()
	{
		Id = id;
		HexColor = hexColor;
		ObjectId = objectId;
		UserId = userId;
		ObjectType = objectType;
	}

	public ObjectColor(string hexColor, Guid objectId, Guid userId, ObjectType objectType)
		: this(Guid.NewGuid(), hexColor, objectId, userId, objectType)
	{
	}
}
