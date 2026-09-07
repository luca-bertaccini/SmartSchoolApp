using BlaisePascal.SmartSchoolApp.SharedKernel;
using Domain.UserManagement;
using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.UserManagement.Repository
{
    public interface IUserRepository
    {
        Result Add(User user);
        Result Update(User user);
        Result Remove(Guid id);
        Result<User> GetById(Guid id);
        Result<List<User>> GetAll();
        Result<User> GetByEmail(string email);
    }
}
