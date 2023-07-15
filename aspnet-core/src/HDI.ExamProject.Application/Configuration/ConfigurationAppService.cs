using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HDI.ExamProject.Configuration.Dto;

namespace HDI.ExamProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ExamProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
