using Domain.UserManagement;

namespace Domain.SchoolManagement
{
    public class SchoolMembership
    {
        public Guid SchoolId { get; }
        public Guid UserId { get; }
        public IRole Role { get; private set; }

        public SchoolMembership(Guid schoolId, Guid userId, IRole role)
        {
            SchoolId = schoolId;
            UserId = userId;
            Role = role;
        }
    }
}
