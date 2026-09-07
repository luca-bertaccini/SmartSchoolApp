using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.UserManagement.Repository
{
    public interface IPasswordHasher
    {
        Result<string> Hash(string plainPassword);
        Result Verify(string plainPassword, string passwordHash);
    }
}
