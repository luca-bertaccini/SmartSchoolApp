using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.UserManagement.Events
{
    public sealed class UserRegistered : IDomainEvent
    {
        public Guid UserId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public UserRegistered(Guid userId)
        {
            UserId = userId;
        }
    }
}
