using System;
using Abp.Domain.Entities;

namespace HDI.ExamProject.Service.Dto
{
	public class CreateServiceDto : Entity<Guid>
	{
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}

