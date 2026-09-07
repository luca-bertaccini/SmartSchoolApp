using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.UserManagement.Events
{
    public sealed class UserPreferencesUpdated : IDomainEvent
    {
        public Guid UserId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public UserPreferencesUpdated(Guid userId)
        {
            UserId = userId;
        }
    }
}
