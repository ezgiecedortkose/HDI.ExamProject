using System;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;
using HDI.ExamProject.Dealer.Dto;
using HDI.ExamProject.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HDI.ExamProject.Dealer
{
    public class DealerAppService : AsyncCrudAppService<Dealers, DealerDto, Guid, PagedAndSortedResultRequestDto, CreateDealerDto, UpdateDealerDto>, IDealerAppService
    {
        public DealerAppService(IRepository<Dealers, Guid> repository)
            : base(repository)
        {
        }

        public async Task<ListResultDto<DealerDto>> GetAll()
        {
            var dealers = await Repository.GetAllListAsync();
            return new ListResultDto<DealerDto>(ObjectMapper.Map<List<DealerDto>>(dealers));
        }
    }
}


