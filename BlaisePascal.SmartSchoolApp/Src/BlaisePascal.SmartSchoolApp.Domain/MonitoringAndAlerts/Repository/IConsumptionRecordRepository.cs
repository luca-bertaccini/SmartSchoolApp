using BlaisePascal.SmartSchoolApp.SharedKernel;
using Domain.MonitoringAndAlerts;
using System;
using System.Collections.Generic;

namespace BlaisePascal.SmartSchoolApp.Domain.MonitoringAndAlerts.Repository
{
    public interface IConsumptionRecordRepository
    {
        Result Add(ConsumptionRecord entity);
        Result Update(ConsumptionRecord entity);
        Result Delete(Guid id);
        Result<ConsumptionRecord> GetById(Guid id);
        Result<List<ConsumptionRecord>> GetAll();
    }
}
