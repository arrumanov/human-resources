using HR.CrossCutting.Enum;

namespace HR.Domain.Model;
public class Permission
{
	protected Permission()
	{
	}


	protected Permission(Guid id, ObjectType objectType, Guid resourceId, Guid objectId, SystemRoleType roleType)
		: this()
	{
		Id = id;
		ObjectType = objectType;
		ResourceId = resourceId;
		ObjectId = objectId;
		RoleType = roleType;
	}

	public Permission(ObjectType objectType, Guid resourceId, Guid objectId, SystemRoleType roleType)
		: this(Guid.NewGuid(), objectType, resourceId, objectId, roleType)
	{
	}

	public Guid Id { get; set; }
	public ObjectType ObjectType { get; set; }
	public Guid ResourceId { get; set; }
	public Guid ObjectId { get; set; }
	public SystemRoleType RoleType { get; set; }

	public Resource Resource { get; set; } = default!;
	public Resource ObjectResource { get; set; } = default!;
	//public Mentorship.Mentorship ObjectMentorship { get; set; }
}
