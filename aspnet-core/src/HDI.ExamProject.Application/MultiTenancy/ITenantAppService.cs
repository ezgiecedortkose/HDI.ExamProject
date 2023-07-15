using Abp.Application.Services;
using HDI.ExamProject.MultiTenancy.Dto;

namespace HDI.ExamProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

