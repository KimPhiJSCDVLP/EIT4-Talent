using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using EIT4Talent.Configuration.Dto;

namespace EIT4Talent.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EIT4TalentAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
