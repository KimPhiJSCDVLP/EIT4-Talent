using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace EIT4Talent.Controllers
{
    public abstract class EIT4TalentControllerBase: AbpController
    {
        protected EIT4TalentControllerBase()
        {
            LocalizationSourceName = EIT4TalentConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
