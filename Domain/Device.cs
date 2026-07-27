using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Device
    {
        public Guid DeviceId { get; set; }
        public string Name { get; set; }
        public DeviceType DeviceType { get; set; }
        public DeviceStatus Status { get; set; }
        public Guid SchoolId { get; set; }
        public Guid RoomId { get; set; }
        public DateTime InstalledAt { get; set; }
        public Specifications Specifications { get; set; }

        public Device(string name, Specifications specifications)
        {
            DeviceId = Guid.NewGuid();
            SchoolId = Guid.NewGuid();
            RoomId = Guid.NewGuid();
            InstalledAt = DateTime.UtcNow;
            Status = DeviceStatus.Off;
            Specifications = specifications;
        }


    }
}
