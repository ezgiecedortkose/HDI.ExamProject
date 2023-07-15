using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;

namespace HDI.ExamProject.Service.Dto
{
	public class UpdateServiceDto : IEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}

