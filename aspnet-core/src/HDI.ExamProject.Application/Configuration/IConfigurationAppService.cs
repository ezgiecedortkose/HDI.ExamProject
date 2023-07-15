using System.Threading.Tasks;
using HDI.ExamProject.Configuration.Dto;

namespace HDI.ExamProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
