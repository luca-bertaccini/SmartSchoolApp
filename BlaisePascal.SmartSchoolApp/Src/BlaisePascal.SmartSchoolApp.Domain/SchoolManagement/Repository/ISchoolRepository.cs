using BlaisePascal.SmartSchoolApp.SharedKernel;
using Domain.SchoolManagement;
using System;
using System.Collections.Generic;

namespace BlaisePascal.SmartSchoolApp.Domain.SchoolManagement.Repository
{
    public interface ISchoolRepository
    {
        Result Add(School entity);
        Result Update(School entity);
        Result Delete(Guid id);
        Result<School> GetById(Guid id);
        Result<List<School>> GetAll();
    }
}
