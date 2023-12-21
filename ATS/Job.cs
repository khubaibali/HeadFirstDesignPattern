using ATS.Users;
namespace ATS;

public class Job
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string NameAr {  get; set; }
    public string Description { get; set; }
    public string DescriptionAr { get; set; }
    public string Responsibility { get; set; }
    public string ResponsibilityAr { get; set; }
    public string Objective { get; set; }
    public string ObjectiveAr { get; set;}
    public User CreatedBy { get; set; }
}

public class JobRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string NameAr { get; set; }
    public string Description { get; set; }
    public bool IsPortfolioRequired {  get; private set; } 
    public string AdditionalComments { get; private set; }
    public readonly JobDescription JobDescription = null!;
    public User CreatedBy { get; private set; }
}
