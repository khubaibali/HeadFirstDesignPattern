using ATS.Abstraction;

namespace ATS;

public sealed class Category : Entity
{
    public Category(Guid id) : base(id)
    {
    }

    public string Name { get; set; } = null!;
}
