using Domain.DeviceManagement;
using BlaisePascal.SmartSchoolApp.Domain.DeviceManagement.Repository;
using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlaisePascal.SmartSchoolApp.Infrastructure.Repositories.DeviceManagement.Devices
{
    public class InMemoryDeviceRepository : IDeviceRepository
    {
        private readonly List<Device> _items;

        public InMemoryDeviceRepository()
        {
            _items = new List<Device>();
        }

        public Result<List<Device>> GetAll()
        {
            return Result<List<Device>>.Success(_items);
        }

        public Result<Device> GetById(Guid id)
        {
            var item = _items.FirstOrDefault(x => x.DeviceId == id);
            if (item == null)
                return Result<Device>.Failure(Error.NotFound("Device.NotFound", "Device cannot be null"));
            return Result<Device>.Success(item);               
        }

        public Result Add(Device entity)
        {
            if (entity != null)
            {
                _items.Add(entity);
                return Result.Success();
            }
            else
            {
                return Result.Failure(Error.NotFound("Device.NotFound", "Device cannot be null"));
            }
        }

        public Result Delete(Guid id)
        {
            var item = GetById(id);
            if (item.IsFailure)
                return Result.Failure(Error.NotFound("Device.NotFound", "Device cannot be null"));
            _items.Remove(item.Value);
            return Result.Success();
        }

        public Result Update(Device entity)
        {
            var existingItemResult = GetById(entity.DeviceId);
            if (existingItemResult.IsFailure)
                return Result.Failure(existingItemResult.Error);
            
            var existingItem = existingItemResult.Value;
            _items.Remove(existingItem);
            _items.Add(entity);
            return Result.Success();
        }

    }
}
