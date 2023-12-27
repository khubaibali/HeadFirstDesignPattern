

namespace ATS.Abstraction;

public abstract class Entity
{
    private readonly List<IDomainEvent> domainEvents = new();
    protected Entity(Guid id) 
    {
        Id = id;
    }
    public Guid Id { get; private init; }

    public override bool Equals(object? obj)
    {
       if(obj is null)
       {
            return false;
       }
       if(obj.GetType() != this.GetType())
       {
            return false;
       }
       if(obj is not Entity entity)
        {
            return false;
        }
       return entity.Id == Id;
    }
    public List<IDomainEvent> DomainEvents => domainEvents.ToList();

   protected void Raise(IDomainEvent domainEvent)
   {
        this.domainEvents.Add(domainEvent);
   }

}

public interface IDomainEvent
{

}
