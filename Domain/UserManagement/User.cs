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
        public Guid UserId { get; }
        public Email Email { get; set; }
        public ZoneTime TimeZone { get; set; } //Ho chiamato "TimeZone" => "ZoneTime" poichè la prima parola rappresentava un costrutto giàpresente in c# dato obsoleto
        public Locale State { get; set; }
    }
}
