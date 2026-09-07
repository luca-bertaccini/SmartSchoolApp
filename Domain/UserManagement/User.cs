using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UserManagement
{
    public class User
    {
        public Guid UserId { get; private set; }
        public Email Email { get; private set; }
        public ZoneTime TimeZone { get; private set; } //Ho chiamato il value object "TimeZone" => "ZoneTime" poichè la prima parola rappresentava un costrutto giàpresente in c# dato obsoleto
        public Locale State { get; private set; }
    }
}
