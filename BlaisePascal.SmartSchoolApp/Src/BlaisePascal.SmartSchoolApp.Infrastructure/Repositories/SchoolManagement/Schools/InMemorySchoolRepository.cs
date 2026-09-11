using Domain.SchoolManagement;
using BlaisePascal.SmartSchoolApp.Domain.SchoolManagement.Repository;
using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlaisePascal.SmartSchoolApp.Infrastructure.Repositories.SchoolManagement.Schools
{
    public class InMemorySchoolRepository : ISchoolRepository
    {
        private readonly List<School> _items;

        public InMemorySchoolRepository()
        {
            _items = new List<School>();
        }

        public Result<List<School>> GetAll()
        {
            return Result<List<School>>.Success(_items);
        }

        public Result<School> GetById(Guid id)
        {
            var item = _items.FirstOrDefault(x => x.SchoolId == id);
            if (item == null)
                return Result<School>.Failure(Error.NotFound("School.NotFound", "School cannot be null"));
            return Result<School>.Success(item);               
        }

        public Result Add(School entity)
        {
            if (entity != null)
            {
                _items.Add(entity);
                return Result.Success();
            }
            else
            {
                return Result.Failure(Error.NotFound("School.NotFound", "School cannot be null"));
            }
        }

        public Result Delete(Guid id)
        {
            var item = GetById(id);
            if (item.IsFailure)
                return Result.Failure(Error.NotFound("School.NotFound", "School cannot be null"));
            _items.Remove(item.Value);
            return Result.Success();
        }

        public Result Update(School entity)
        {
            var existingItemResult = GetById(entity.SchoolId);
            if (existingItemResult.IsFailure)
                return Result.Failure(existingItemResult.Error);
            
            var existingItem = existingItemResult.Value;
            _items.Remove(existingItem);
            _items.Add(entity);
            return Result.Success();
        }

    }
}
