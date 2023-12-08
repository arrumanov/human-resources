namespace HR.Domain.Model;
public class HeadOfDepartment
{
	public Guid Id { get; set; }
	public string? Name { get; set; }
	public Guid DepartmentId { get; set; }
	public Guid CompanyId { get; set; }
	public Guid? ParentId { get; set; }
	public Guid? HeadOfDepartmentId { get; set; }
	public bool IsActive { get; set; }
	public bool IsIdFromDocup { get; set; }
	public DateTime UpdateDate { get; set; }
	/// <summary>
	/// заместитель
	/// </summary>
	public Guid? DeputyId { get; set; }
	public List<Guid> DepartmentsId { get; set; } = new();
	public string? Code { get; set; }
	public bool IsEditableOnlyByUser { get; set; }

	public Resource HeadResource { get; set; } = default!;
	public Resource DeputyHeadResource { get; set; } = default!;


	protected HeadOfDepartment()
	{
	}

	protected HeadOfDepartment(Guid id, string name, Guid departmentId, Guid? parentId, 
		Guid? headOfDepartmentId, bool isActive, bool isIdFromDocUp, DateTime updateDate, Guid companyId)
	{
		Id = id;
		Name = name;
		DepartmentId = departmentId;
		ParentId = parentId;
		HeadOfDepartmentId = headOfDepartmentId;
		IsActive = isActive;
		IsIdFromDocup = isIdFromDocUp;
		UpdateDate = updateDate;
		CompanyId = companyId;
	}

	public HeadOfDepartment(string name, Guid departmentId, Guid? parentId, 
		Guid? headOfDepartmentId, bool isActive, bool isIdFromDocUp, Guid companyId)
		: this(Guid.NewGuid(), name, departmentId, parentId, headOfDepartmentId, isActive, isIdFromDocUp, DateTime.Now, companyId)
	{

	}
}
