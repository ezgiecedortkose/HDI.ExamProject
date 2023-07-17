using System;
using Abp.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using HDI.ExamProject.Dealer.Dto;
using HDI.ExamProject.Service.Dto;

namespace HDI.ExamProject.Service
{
    public interface IServiceAppService : IAsyncCrudAppService<ServiceDto, Guid, PagedAndSortedResultRequestDto, CreateServiceDto, UpdateServiceDto>
    {
        Task<ServiceDto> GetAsync(Guid id);
    }

}

