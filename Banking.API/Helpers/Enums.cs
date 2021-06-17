using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Helpers
{
    public enum UserType
    {
        Admin = 1,
        User = 2
    }

    public enum LoginIdentifier
    {
        Login = 1,
        CustomerNumber = 2
    }
}
