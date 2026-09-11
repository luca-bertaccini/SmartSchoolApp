using Domain.MonitoringAndAlerts;
using BlaisePascal.SmartSchoolApp.Domain.MonitoringAndAlerts.Repository;
using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlaisePascal.SmartSchoolApp.Infrastructure.Repositories.MonitoringAndAlerts.Alerts
{
    public class InMemoryAlertRepository : IAlertRepository
    {
        private readonly List<Alert> _items;

        public InMemoryAlertRepository()
        {
            _items = new List<Alert>();
        }

        public Result<List<Alert>> GetAll()
        {
            return Result<List<Alert>>.Success(_items);
        }

        public Result<Alert> GetById(Guid id)
        {
            var item = _items.FirstOrDefault(x => x.AlertId == id);
            if (item == null)
                return Result<Alert>.Failure(Error.NotFound("Alert.NotFound", "Alert cannot be null"));
            return Result<Alert>.Success(item);               
        }

        public Result Add(Alert entity)
        {
            if (entity != null)
            {
                _items.Add(entity);
                return Result.Success();
            }
            else
            {
                return Result.Failure(Error.NotFound("Alert.NotFound", "Alert cannot be null"));
            }
        }

        public Result Delete(Guid id)
        {
            var item = GetById(id);
            if (item.IsFailure)
                return Result.Failure(Error.NotFound("Alert.NotFound", "Alert cannot be null"));
            _items.Remove(item.Value);
            return Result.Success();
        }

        public Result Update(Alert entity)
        {
            var existingItemResult = GetById(entity.AlertId);
            if (existingItemResult.IsFailure)
                return Result.Failure(existingItemResult.Error);
            
            var existingItem = existingItemResult.Value;
            _items.Remove(existingItem);
            _items.Add(entity);
            return Result.Success();
        }

    }
}
