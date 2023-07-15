using System;
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using HDI.ExamProject.Product.Dto;

namespace HDI.ExamProject.Dealer.Dto
{
	public class DealerDto : IEntityDto<Guid>
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<ProductDto> Products { get; set; }
    }
}

