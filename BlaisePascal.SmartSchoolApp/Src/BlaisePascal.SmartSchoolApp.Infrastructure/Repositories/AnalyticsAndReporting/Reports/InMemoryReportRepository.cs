using Domain.AnalyticsAndReporting;
using BlaisePascal.SmartSchoolApp.Domain.AnalyticsAndReporting.Repository;
using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlaisePascal.SmartSchoolApp.Infrastructure.Repositories.AnalyticsAndReporting.Reports
{
    public class InMemoryReportRepository : IReportRepository
    {
        private readonly List<Report> _items;

        public InMemoryReportRepository()
        {
            _items = new List<Report>();
        }

        public Result<List<Report>> GetAll()
        {
            return Result<List<Report>>.Success(_items);
        }

        public Result<Report> GetById(Guid id)
        {
            var item = _items.FirstOrDefault(x => x.ReportId == id);
            if (item == null)
                return Result<Report>.Failure(Error.NotFound("Report.NotFound", "Report cannot be null"));
            return Result<Report>.Success(item);               
        }

        public Result Add(Report entity)
        {
            if (entity != null)
            {
                _items.Add(entity);
                return Result.Success();
            }
            else
            {
                return Result.Failure(Error.NotFound("Report.NotFound", "Report cannot be null"));
            }
        }

        public Result Delete(Guid id)
        {
            var item = GetById(id);
            if (item.IsFailure)
                return Result.Failure(Error.NotFound("Report.NotFound", "Report cannot be null"));
            _items.Remove(item.Value);
            return Result.Success();
        }

        public Result Update(Report entity)
        {
            var existingItemResult = GetById(entity.ReportId);
            if (existingItemResult.IsFailure)
                return Result.Failure(existingItemResult.Error);
            
            var existingItem = existingItemResult.Value;
            _items.Remove(existingItem);
            _items.Add(entity);
            return Result.Success();
        }

    }
}
