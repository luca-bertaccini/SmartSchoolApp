using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UserManagement
{
    public class Session
    {
        public Guid SessionId { get; private set; }
        public Guid UserId { get; private set; }
        public DateTime ExpiresAt { get; private set; }

        public Session(Guid userId, TimeSpan duration)
        {
            SessionId = Guid.NewGuid();
            UserId = userId;
            ExpiresAt = DateTime.UtcNow.Add(duration);
        }
    }
}
