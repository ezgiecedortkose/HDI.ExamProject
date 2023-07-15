using System.Threading.Tasks;
using Abp.Application.Services;
using HDI.ExamProject.Sessions.Dto;

namespace HDI.ExamProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
