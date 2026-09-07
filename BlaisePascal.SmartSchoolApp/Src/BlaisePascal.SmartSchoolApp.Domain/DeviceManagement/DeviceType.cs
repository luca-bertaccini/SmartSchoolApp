using Domain.ValueObject;

namespace Domain.DeviceManagement
{
    public class DeviceType
    {
        public Guid TypeId { get; set; }
        public Name Name { get; set; }
        public string Capabilities { get; set; }
        public EnergyProfile EnergyProfile { get; set; }
    }
}
