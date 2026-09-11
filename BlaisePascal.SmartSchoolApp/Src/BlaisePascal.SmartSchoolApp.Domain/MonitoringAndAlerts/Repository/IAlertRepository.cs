using BlaisePascal.SmartSchoolApp.SharedKernel;
using Domain.MonitoringAndAlerts;
using System;
using System.Collections.Generic;

namespace BlaisePascal.SmartSchoolApp.Domain.MonitoringAndAlerts.Repository
{
    public interface IAlertRepository
    {
        Result Add(Alert entity);
        Result Update(Alert entity);
        Result Delete(Guid id);
        Result<Alert> GetById(Guid id);
        Result<List<Alert>> GetAll();
    }
}
