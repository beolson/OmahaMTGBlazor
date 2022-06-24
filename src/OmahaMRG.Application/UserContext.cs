using OmahaMRG.Application.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmahaMRG.Application
{
    public class UserContext
    {
        public UserContext(string userId, string userName, IEnumerable<ApplicationRoles> roles, bool isLoggedIn)
        {
            UserId = userId;
            UserName = userName;
            Roles = roles;
            IsLoggedIn = isLoggedIn;
        }

        public string UserId { get; }

        public string UserName { get; }

        public IEnumerable<ApplicationRoles> Roles { get; }

        public bool IsLoggedIn { get; }

        public bool UserHasRole(ApplicationRoles role)
        {
            return Roles.Contains(role);
        }
    }
}
