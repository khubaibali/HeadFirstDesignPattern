using ATS.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS;

public class UserRoles : Entity
{
    public UserRoles(Guid id) : base(id)
    {
    }

    public string Name { get; set; }
}
