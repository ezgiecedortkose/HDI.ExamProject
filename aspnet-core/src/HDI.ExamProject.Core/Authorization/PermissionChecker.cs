using Abp.Authorization;
using HDI.ExamProject.Authorization.Roles;
using HDI.ExamProject.Authorization.Users;

namespace HDI.ExamProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
