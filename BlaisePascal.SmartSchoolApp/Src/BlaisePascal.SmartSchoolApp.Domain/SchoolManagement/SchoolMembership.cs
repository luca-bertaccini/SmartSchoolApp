using Domain.UserManagement;

namespace Domain.SchoolManagement
{
    public class SchoolMembership
    {
        public Guid SchoolId { get; }   // Id della scuola e dello studente
        public Guid UserId { get; }
        public Role Role { get; private set; }

        public SchoolMembership(Guid schoolId, Guid userId, Role role)
        {
            SchoolId = schoolId;
            UserId = userId;
            Role = role;
        }
    }
}
