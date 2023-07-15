using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HDI.ExamProject.MultiTenancy;

namespace HDI.ExamProject.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
