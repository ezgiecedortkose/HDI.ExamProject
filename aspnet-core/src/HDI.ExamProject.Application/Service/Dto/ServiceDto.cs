using System;
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using HDI.ExamProject.Product.Dto;

namespace HDI.ExamProject.Service.Dto
{
	public class ServiceDto : IEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<ProductDto> Products { get; set; }
    }
}

