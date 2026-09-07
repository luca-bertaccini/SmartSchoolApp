using Domain.ValueObject;

namespace Domain.DeviceManagement
{
    public class Device
    {
        public Guid DeviceId { get; set; }
        public Name Name { get; set; }
        public DeviceType DeviceType { get; set; }
        public IDeviceStatus Status { get; set; }
        public Guid SchoolId { get; set; }
        public Guid RoomId { get; set; }
        public DateTime InstalledAt { get; set; }
        public ISpecifications Specifications { get; set; }

        public Device(string name, ISpecifications specifications)
        {
            DeviceId = Guid.NewGuid();
            SchoolId = Guid.NewGuid();
            RoomId = Guid.NewGuid();
            InstalledAt = DateTime.UtcNow;
            Status = IDeviceStatus.Off;
            Specifications = specifications;
            Name = Name.Create(name);
        }


    }
}
