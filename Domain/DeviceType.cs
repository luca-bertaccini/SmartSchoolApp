using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DeviceType
    {
        public Guid TypeId { get; set; }
        public Name Name { get; set; }
        public string Capabilities { get; set; }
        public EnergyProfile EnergyProfile { get; set; }
    }
}
