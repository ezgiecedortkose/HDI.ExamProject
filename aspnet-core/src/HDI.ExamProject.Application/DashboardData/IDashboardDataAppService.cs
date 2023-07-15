using System;
using Abp.Application.Services;
using System.Threading.Tasks;
using HDI.ExamProject.DashboardData.Dto;

namespace HDI.ExamProject.DashboardData
{
    public interface IDashboardDataAppService : IApplicationService
    {
        Task<DashboardDataDto> GetDashboardData();
    }
}

