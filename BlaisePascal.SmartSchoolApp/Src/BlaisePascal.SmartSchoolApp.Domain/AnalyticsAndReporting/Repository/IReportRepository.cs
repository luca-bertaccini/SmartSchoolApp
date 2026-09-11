using BlaisePascal.SmartSchoolApp.SharedKernel;
using Domain.AnalyticsAndReporting;
using System;
using System.Collections.Generic;

namespace BlaisePascal.SmartSchoolApp.Domain.AnalyticsAndReporting.Repository
{
    public interface IReportRepository
    {
        Result Add(Report entity);
        Result Update(Report entity);
        Result Delete(Guid id);
        Result<Report> GetById(Guid id);
        Result<List<Report>> GetAll();
    }
}
