using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace Domain.SchoolManagement.Events
{
    public record SchoolCreated(Guid SchoolId) : IDomainEvent;
    public record UserInvitedToSchool(Guid SchoolId, Guid UserId) : IDomainEvent;
    public record MembershipRoleChanged(Guid SchoolId, Guid UserId, string NewRole) : IDomainEvent;
    public record MemberRemovedFromSchool(Guid SchoolId, Guid UserId) : IDomainEvent;
    public record SchoolOwnershipTransferred(Guid SchoolId, Guid NewOwnerId) : IDomainEvent;
}
