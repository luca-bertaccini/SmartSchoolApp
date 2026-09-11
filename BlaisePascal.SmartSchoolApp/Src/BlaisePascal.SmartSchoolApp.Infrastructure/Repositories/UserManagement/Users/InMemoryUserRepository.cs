using Domain.UserManagement;
using BlaisePascal.SmartSchoolApp.Domain.UserManagement.Repository;
using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlaisePascal.SmartSchoolApp.Infrastructure.Repositories.UserManagement.Users
{
    public class InMemoryUserRepository : IUserRepository
    {
        private readonly List<User> _items;

        public InMemoryUserRepository()
        {
            _items = new List<User>();
        }

        public Result<List<User>> GetAll()
        {
            return Result<List<User>>.Success(_items);
        }

        public Result<User> GetById(Guid id)
        {
            var item = _items.FirstOrDefault(x => x.UserId == id);
            if (item == null)
                return Result<User>.Failure(Error.NotFound("User.NotFound", "User cannot be null"));
            return Result<User>.Success(item);               
        }

        public Result Add(User entity)
        {
            if (entity != null)
            {
                _items.Add(entity);
                return Result.Success();
            }
            else
            {
                return Result.Failure(Error.NotFound("User.NotFound", "User cannot be null"));
            }
        }

        public Result Delete(Guid id)
        {
            var item = GetById(id);
            if (item.IsFailure)
                return Result.Failure(Error.NotFound("User.NotFound", "User cannot be null"));
            _items.Remove(item.Value);
            return Result.Success();
        }

        public Result Update(User entity)
        {
            var existingItemResult = GetById(entity.UserId);
            if (existingItemResult.IsFailure)
                return Result.Failure(existingItemResult.Error);
            
            var existingItem = existingItemResult.Value;
            _items.Remove(existingItem);
            _items.Add(entity);
            return Result.Success();
        }
        public Result Remove(Guid id)
        {
            return Delete(id);
        }

        public Result<User> GetByEmail(string email)
        {
            var user = _items.FirstOrDefault(x => x.Email.Value == email);
            if (user == null)
                return Result<User>.Failure(Error.NotFound("User.NotFound", "User not found"));
            return Result<User>.Success(user);
        }
    }
}
