using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.UserManagement.Events
{
    public sealed class UserAuthenticated : IDomainEvent
    {
        public Guid UserId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public UserAuthenticated(Guid userId)
        {
            UserId = userId;
        }
    }
}
