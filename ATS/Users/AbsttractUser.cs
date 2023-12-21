using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Users
{
    public abstract class User
    {
        public User(string Name, string Email, string Password, string UserName)
        {
            Name = Name;
            Email = Email;
            Password = Password;
            UserName = UserName;
        }
        public List<UserRoles> Roles = new();
        public string Name { get;private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string UserName { get; private set; }

        
    }

    public sealed class LineManager : User 
    {
        public LineManager(string Name,string Email,string Password,string UserName):base(Name,Email,Password,UserName)
        {
            
        }
    }

    public sealed class HrManager : User
    {
        public HrManager(string Name, string Email, string Password, string UserName) : base(Name, Email, Password, UserName)
        {
        }
    }

    public sealed class Recruiter : User
    {
        public Recruiter(string Name, string Email, string Password, string UserName) : base(Name, Email, Password, UserName)
        {
        }
    }

    public sealed class Applicant : User
    {
        public Applicant(string Name, string Email, string Password, string UserName) : base(Name, Email, Password, UserName)
        {
        }
    }
}
