using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SchoolManagement
{
    public class School
    {
        public Guid SchoolId { get; private set; }
        public Name Name { get; private set; }
        public Guid OwnerId { get; private set; }
        public Address Address { get; private set; }

        private School()
        {
            SchoolId = Guid.NewGuid();
            OwnerId = Guid.NewGuid();
        }

        public School CreateSchool() => new School(); 

        public void InviteUserToSchool() { } // Necessita della classe User

    }
}
