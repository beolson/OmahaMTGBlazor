using OmahaMRG.Application.Common.Enum;
using OmahaMRG.Application.Common.Exceptions;
using System.Runtime.CompilerServices;


namespace OmahaMRG.Application
{
    internal abstract class ManagerBase
    {
        private readonly UserContext _userContext;

        public ManagerBase(UserContext userContext)
        {
            _userContext = userContext;
        }

        internal void EnsureUserInRoll(IEnumerable<ApplicationRoles> allowedRolls, [CallerMemberName] string callerName = "")
        {
            IEnumerable<ApplicationRoles> matchingRoles = allowedRolls.Intersect(_userContext.Roles);

            if (matchingRoles.Any())
            {
                return;
            }

            throw new NotAuthorizedException(_userContext.UserName, GetType().FullName ?? string.Empty, callerName);
        }
    }
}
