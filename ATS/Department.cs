using ATS.Abstraction;

namespace ATS;

public sealed class Department : Entity
{
    public Department(Guid id) : base(id)
    {
    }
    public string Name { get; set; } = null!;
    
}
