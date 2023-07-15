using Abp.AutoMapper;
using HDI.ExamProject.Sessions.Dto;

namespace HDI.ExamProject.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
