using BlaisePascal.SmartSchoolApp.SharedKernel;
using Domain.DeviceManagement;
using System;
using System.Collections.Generic;

namespace BlaisePascal.SmartSchoolApp.Domain.DeviceManagement.Repository
{
    public interface IDeviceRepository
    {
        Result Add(Device entity);
        Result Update(Device entity);
        Result Delete(Guid id);
        Result<Device> GetById(Guid id);
        Result<List<Device>> GetAll();
    }
}
