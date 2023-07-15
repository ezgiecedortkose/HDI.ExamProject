using System;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper.Internal.Mappers;
using System.Threading.Tasks;
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using HDI.ExamProject.Entities;
using HDI.ExamProject.Service.Dto;

namespace HDI.ExamProject.Service
{
    public class ServiceAppService : AsyncCrudAppService<Services, ServiceDto, Guid, PagedAndSortedResultRequestDto, CreateServiceDto, UpdateServiceDto>, IServiceAppService
    {
        public ServiceAppService(IRepository<Services, Guid> repository)
            : base(repository)
        {
        }
    }

}