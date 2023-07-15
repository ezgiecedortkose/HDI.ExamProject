using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HDI.ExamProject.Controllers
{
    public abstract class ExamProjectControllerBase: AbpController
    {
        protected ExamProjectControllerBase()
        {
            LocalizationSourceName = ExamProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
