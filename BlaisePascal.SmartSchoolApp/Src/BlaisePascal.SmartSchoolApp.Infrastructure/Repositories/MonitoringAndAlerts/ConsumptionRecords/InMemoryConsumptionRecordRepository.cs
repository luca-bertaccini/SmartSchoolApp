using Domain.MonitoringAndAlerts;
using BlaisePascal.SmartSchoolApp.Domain.MonitoringAndAlerts.Repository;
using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlaisePascal.SmartSchoolApp.Infrastructure.Repositories.MonitoringAndAlerts.ConsumptionRecords
{
    public class InMemoryConsumptionRecordRepository : IConsumptionRecordRepository
    {
        private readonly List<ConsumptionRecord> _items;

        public InMemoryConsumptionRecordRepository()
        {
            _items = new List<ConsumptionRecord>();
        }

        public Result<List<ConsumptionRecord>> GetAll()
        {
            return Result<List<ConsumptionRecord>>.Success(_items);
        }

        public Result<ConsumptionRecord> GetById(Guid id)
        {
            var item = _items.FirstOrDefault(x => x.RecordId == id);
            if (item == null)
                return Result<ConsumptionRecord>.Failure(Error.NotFound("ConsumptionRecord.NotFound", "ConsumptionRecord cannot be null"));
            return Result<ConsumptionRecord>.Success(item);               
        }

        public Result Add(ConsumptionRecord entity)
        {
            if (entity != null)
            {
                _items.Add(entity);
                return Result.Success();
            }
            else
            {
                return Result.Failure(Error.NotFound("ConsumptionRecord.NotFound", "ConsumptionRecord cannot be null"));
            }
        }

        public Result Delete(Guid id)
        {
            var item = GetById(id);
            if (item.IsFailure)
                return Result.Failure(Error.NotFound("ConsumptionRecord.NotFound", "ConsumptionRecord cannot be null"));
            _items.Remove(item.Value);
            return Result.Success();
        }

        public Result Update(ConsumptionRecord entity)
        {
            var existingItemResult = GetById(entity.RecordId);
            if (existingItemResult.IsFailure)
                return Result.Failure(existingItemResult.Error);
            
            var existingItem = existingItemResult.Value;
            _items.Remove(existingItem);
            _items.Add(entity);
            return Result.Success();
        }

    }
}
