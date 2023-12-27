using ATS.Abstraction;

namespace ATS.Users;

public sealed class Profile : Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }    
    public string MiddleName { get; set; }
    public Guid ApplicantId { get; set; }
    public string Email { get; set; }   
    public DateTimeOffset DateOfBirth { get; set; }

}
