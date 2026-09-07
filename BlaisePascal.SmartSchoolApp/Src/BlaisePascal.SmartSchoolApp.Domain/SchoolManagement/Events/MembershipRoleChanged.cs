using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.SchoolManagement.Events
{
    public sealed class MembershipRoleChanged : IDomainEvent
    {
        public Guid SchoolId { get; }
        public Guid UserId { get; }
        public string NewRole { get; }
        public DateTime OccurredOnUtc { get; init; }
        public MembershipRoleChanged(Guid schoolId, Guid userId, string newRole)
        {
            SchoolId = schoolId;
            UserId = userId;
            NewRole = newRole;
        }
    }
}
