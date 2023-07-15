using System.Threading.Tasks;
using Abp.Application.Services;
using HDI.ExamProject.Authorization.Accounts.Dto;

namespace HDI.ExamProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
