namespace ATS;

public class Sector
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = null!;
    public IReadOnlyList<Department> Departments { get; private set; }
}
