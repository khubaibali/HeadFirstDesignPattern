using ATS.Abstraction;
using ATS.Users;
using ATS.ValueObjects;
using System.Runtime.InteropServices;

namespace ATS;

public class Job : Entity 
{
    public Job(Guid id) : base(id)
    {
    }

    public Bilingual Position { get; set; }
    public Bilingual Description { get; set; }
    public Bilingual Responsiblity { get; set; }
    public Bilingual Objective { get; set; }
    public User CreatedBy { get; set; }
}

public sealed class JobRequest : Entity
{
    private JobRequest(
        Guid id,
        Bilingual name, 
        Bilingual description,
        bool isPortfolioRequired,
        string AdditionalComments,
        Guid CreatedBy
        ) :base(id)
    {
        this.Name = name;
        this.Description = description;
        this.IsPortfolioRequired = isPortfolioRequired;
        this.AdditionalComments = AdditionalComments;
        this.CreatedBy = CreatedBy;
    }
    public Bilingual Name { get; private set; }
    public Bilingual Description { get; private set; }
    public bool IsPortfolioRequired {  get; private set; } 
    public string AdditionalComments { get; private set; }
    public Guid CreatedBy { get; set; }
    public static JobRequest Create(
        Guid id,
        Bilingual name,
        Bilingual description,
        bool isPortfolioRequired,
        string AdditionalComments,
        Guid CreatedBy)
    {
       return new JobRequest(id,name,description,isPortfolioRequired,AdditionalComments, CreatedBy);
    }
}

public sealed class JobPost : Entity
{
    public JobPost(Guid id) : base(id)
    {
    }

    public DateTimeOffset PublishDate { get; private set; }
    public DateTimeOffset UnPublishDate { get; private set; }
    public Job Job { get; set; }
    public JobRequest JobRequest { get; set; }
}


public sealed class JobApplication
{
    public Guid Id { get; private set; }
    public User Applicant { get; private set; }

}