using HR.CrossCutting.Enum;

namespace HR.Domain.Model;
public class Favorite
{
	public Guid Id { get; set; }
	public Guid ObjectId { get; set; }
	public FavoriteType FavoriteType { get; set; }
	public Guid UserId { get; set; }

	public Favorite()
	{
	}

	public Favorite(Guid id, FavoriteType favoriteType, Guid objectId, Guid userId)
		: this()
	{
		Id = id;
		FavoriteType = favoriteType;
		ObjectId = objectId;
		UserId = userId;
	}

	public Favorite(FavoriteType favoriteType, Guid objectId, Guid userId)
		: this(Guid.NewGuid(), favoriteType, objectId, userId)
	{
	}
}
