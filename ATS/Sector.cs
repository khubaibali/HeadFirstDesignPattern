using ATS.Abstraction;

namespace ATS;

public class Sector : Entity
{
    public Sector(Guid id) : base(id)
    {
    }

    public string Name { get; private set; } = null!;
    public IReadOnlyList<Department> Departments { get; private set; }
}
