using Abp.Authorization;
using EIT4Talent.Authorization.Roles;
using EIT4Talent.Authorization.Users;

namespace EIT4Talent.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
