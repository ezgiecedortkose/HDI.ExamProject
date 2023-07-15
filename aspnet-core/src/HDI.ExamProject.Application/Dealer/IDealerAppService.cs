using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HDI.ExamProject.Dealer.Dto;

namespace HDI.ExamProject.Dealer
{
    public interface IDealerAppService : IAsyncCrudAppService<DealerDto, Guid, PagedAndSortedResultRequestDto, CreateDealerDto, UpdateDealerDto>
    {
        Task<ListResultDto<DealerDto>> GetAll();
    }
}

