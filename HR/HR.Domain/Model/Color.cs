namespace HR.Domain.Model;
public class Color
{
	public Guid Id { get; set; }
	public string Name { get; set; } = default!;
	public string HexColor { get; set; } = default!;
	public bool IsActive { get; set; }

	protected Color()
	{

	}


	protected Color(Guid id, string name, string hexColor, bool isActive)
		: this()
	{
		Id = id;
		Name = name;
		HexColor = hexColor;
		IsActive = isActive;
	}

	public Color(string name, string hexColor, bool isActive)
		: this(Guid.NewGuid(), name, hexColor, isActive)
	{
	}
}
