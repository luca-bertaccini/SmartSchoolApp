using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class School
    {
        public Guid SchoolId { get; set; }
        public string Name { get; set; }
        public Guid OwnerId { get; set; }

        private School()
        {
            SchoolId = Guid.NewGuid();
            OwnerId = Guid.NewGuid();
        }

        public School CreateSchool() => new School();
    }
}
